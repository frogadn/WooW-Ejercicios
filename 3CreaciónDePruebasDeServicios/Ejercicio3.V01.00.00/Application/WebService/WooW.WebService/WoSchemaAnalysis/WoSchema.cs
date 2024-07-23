using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.VisualBasic;
using Org.BouncyCastle.Asn1.X509;
using ServiceStack;
using ServiceStack.OrmLite;
using WooW.Core;
using WooW.Core.Common;
using WooW.Core.Server;

namespace WooW.WebService.WoSchemaAnalysis
{
    public static class WoSchema
    {
        public static List<WoSchemaEntity> GetSchema(WoTargetConnection woTarget)
        {
            return WoSchema.GetSchema(
                woTarget.Db,
                WoLib.GetDBName(woTarget.Instance, woTarget.InstanceType, woTarget.Year),
                woTarget.DataBaseProvider
            );
        }

        public static List<WoSchemaEntity> GetSchema(
            IDbConnection Db,
            string dbName,
            tWoDataBaseProviders dbProvider
        )
        {
            List<WoSchemaEntity> entities = new List<WoSchemaEntity>();

            List<string> tableNames = Db.GetTableNames();

            foreach (string tableName in tableNames)
            {
                WoSchemaEntity entity = new WoSchemaEntity(Db, dbName, dbProvider, tableName);
                entities.Add(entity);
            }

            return entities;
        }

        public static List<WoSchemaEntity> GetSchemaFromAssembly(
            WoTargetConnection woTarget,
            string AssemblyName,
            string nameSpace
        )
        {
            return WoSchema.GetSchemaFromAssembly(
                woTarget.Db,
                WoLib.GetDBName(woTarget.Instance, woTarget.InstanceType, woTarget.Year),
                AssemblyName,
                nameSpace
            );
        }

        public static List<WoSchemaEntity> GetSchemaFromAssembly(
            IDbConnection Db,
            string dbName,
            string AssemblyName,
            string nameSpace
        )
        {
            List<WoSchemaEntity> entities = new List<WoSchemaEntity>();

            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                var name = assembly.GetName();

                if (name.Name == AssemblyName)
                {
                    var types = assembly.GetTypes().Where(t => t.Namespace == nameSpace).ToList();

                    var ModelDBTypes = types
                        .Where(t =>
                            t.IsSubclassOf(typeof(AWoCatalog))
                            || t.IsSubclassOf(typeof(AWoCatalogSlave))
                            || t.IsSubclassOf(typeof(AWoTransaction))
                            || t.IsSubclassOf(typeof(AWoTransactionSlave))
                            || t.IsSubclassOf(typeof(AWoParameter))
                            || t.IsSubclassOf(typeof(WoControl))
                        )
                        .ToList();

                    foreach (var model in ModelDBTypes)
                    {
                        WoSchemaEntity entity = new WoSchemaEntity(
                            model,
                            dbName,
                            tWoDataBaseProviders.Sqlite,
                            model.Name
                        );
                        entities.Add(entity);
                    }
                }
            }

            return entities;
        }

        public static string CompareSchemaModel(WoTargetConnection woTarget)
        {
            return WoSchema.CompareSchemaModel(
                woTarget.Db,
                WoLib.GetDBName(woTarget.Instance, woTarget.InstanceType, woTarget.Year),
                woTarget.DataBaseProvider
            );
        }

        public static string CompareSchemaModel(
            IDbConnection Db,
            string dbName,
            tWoDataBaseProviders dbProvider
        )
        {
            List<WoSchemaEntity> entities = WoSchema.GetSchema(Db, dbName, dbProvider);
            List<WoSchemaEntity> asmEntities = WoSchema.GetSchemaFromAssembly(
                Db,
                dbName,
                "WooW.WebService",
                "WooW.Model"
            );
            StringBuilder sb = new StringBuilder();
            WoSchema.CompareSchemaModelTable(entities, asmEntities, sb, dbProvider);
            WoSchema.CompareSchemaModelIndex(entities, asmEntities, sb);
            WoSchema.CompareSchemaModelForeing(entities, asmEntities, sb);

            return sb.ToString();
        }

        private static void CompareSchemaModelTable(
            List<WoSchemaEntity> entities,
            List<WoSchemaEntity> asmEntities,
            StringBuilder sb,
            tWoDataBaseProviders dbProvider
        )
        {
            List<string> ambos = new List<string>();

            // Comparar tablas que existen en la base de datos y en el modelo
            foreach (WoSchemaEntity entity in entities)
            {
                if (asmEntities.Any(a => a.EntityName.ToLower() == entity.EntityName.ToLower()))
                {
                    ambos.Add(entity.EntityName.ToLower());
                }
                else
                {
                    if (entity.EntityName.ToLower() == "CrudEvent".ToLower())
                        continue;

                    sb.AppendLine(
                        $"Table en la base de datos {entity.EntityName} no existe en el modelo"
                    );
                }
            }

            // Comparar tablas que existen en el modelo y en la base de datos
            foreach (WoSchemaEntity entity in asmEntities)
            {
                if (asmEntities.Any(a => a.EntityName.ToLower() == entity.EntityName.ToLower()))
                {
                    if (!ambos.Contains(entity.EntityName.ToLower()))
                        ambos.Add(entity.EntityName.ToLower());
                }
                else
                {
                    sb.AppendLine($"Modelo {entity.EntityName} no existe en la base de datos ");
                }
            }

            // Comparar columnas que existen en la base de datos y en el modelo
            foreach (string modelo in ambos)
            {
                // Compara columnas que existen en la base de datos y en el modelo
                WoSchemaEntity entity = entities.FirstOrDefault(e =>
                    e.EntityName.ToLower() == modelo.ToLower()
                );
                WoSchemaEntity asmEntity = asmEntities.FirstOrDefault(e =>
                    e.EntityName.ToLower() == modelo.ToLower()
                );

                foreach (var colEntity in entity.Columns)
                {
                    if (
                        asmEntity.Columns.Any(c =>
                            c.ColumnName.ToLower() == colEntity.ColumnName.ToLower()
                        )
                    )
                    {
                        var asmColEntity = asmEntity.Columns.FirstOrDefault(c =>
                            c.ColumnName.ToLower() == colEntity.ColumnName.ToLower()
                        );

                        if (colEntity.Default.ToSafeString() != asmColEntity.Default.ToSafeString())
                        {
                            bool bDiferente = true;
                            if (
                                (colEntity.TypeColumn == WoTypeColumn.DateTime)
                                || (asmColEntity.TypeColumn == WoTypeColumn.Date)
                            )
                                bDiferente = false;

                            if (
                                (colEntity.ColumnName == "RowVersion")
                                && (asmColEntity.Default.IsDBNullOrStringEmpty())
                            )
                                bDiferente = false;

                            if (
                                (colEntity.TypeColumn == WoTypeColumn.Decimal)
                                && (
                                    (colEntity.Default.ToSafeString() + "m")
                                    == asmColEntity.Default.ToSafeString().ToLower()
                                )
                            )
                                bDiferente = false;

                            // No jala el proceso en ServiceStack
                            //if ((asmColEntity.TypeColumn == WoTypeColumn.Boolean) &&
                            //    (((colEntity.Default.ToSafeString() == "0") && (asmColEntity.Default.ToSafeString() == "false")) ||
                            //     ((colEntity.Default.ToSafeString() == "1") && (asmColEntity.Default.ToSafeString() == "true"))))
                            //    bDiferente = false;
                            if (asmColEntity.TypeColumn == WoTypeColumn.Boolean)
                                bDiferente = false;

                            if (
                                (asmColEntity.TypeColumn == WoTypeColumn.String)
                                && (!asmColEntity.Default.ToSafeString().StartsWith("\""))
                            )
                                bDiferente = false;

                            if (
                                (asmColEntity.TypeColumn == WoTypeColumn.EnumInt)
                                || (asmColEntity.TypeColumn == WoTypeColumn.EnumString)
                            )
                                bDiferente = false;

                            if (asmColEntity.TypeColumn == WoTypeColumn.Reference)
                                bDiferente = false;

                            if (colEntity.ColumnName == "GuidId")
                                bDiferente = false;

                            if (bDiferente)
                                sb.AppendLine(
                                    $"Modelo:{entity.EntityName} Columna:{colEntity.ColumnName} en la base de datos, el default es:{colEntity.Default.ToSafeString()} y en el modelo es:{asmColEntity.Default.ToSafeString()}"
                                );
                        }

                        if (colEntity.Null != asmColEntity.Null)
                        {
                            bool bDiferente = true;
                            if (asmColEntity.Primary)
                                bDiferente = false;

                            if (bDiferente)
                                sb.AppendLine(
                                    $"Modelo:{entity.EntityName} Columna:{colEntity.ColumnName} en la base de datos, acepta nulos es:{colEntity.Null.ToSafeString()} y en el modelo es:{asmColEntity.Null.ToSafeString()}"
                                );
                        }

                        if (colEntity.Primary != asmColEntity.Primary)
                            sb.AppendLine(
                                $"Modelo:{entity.EntityName} Columna:{colEntity.ColumnName} en la base de datos, primaria es:{colEntity.Primary.ToSafeString()} y en el modelo es:{asmColEntity.Primary.ToSafeString()}"
                            );

                        if (colEntity.TypeColumn != asmColEntity.TypeColumn)
                        {
                            bool bDiferente = true;
                            if (
                                (colEntity.TypeColumn == WoTypeColumn.Integer)
                                && (asmColEntity.TypeColumn == WoTypeColumn.WoState)
                            )
                                bDiferente = false;

                            if (
                                (colEntity.TypeColumn == WoTypeColumn.Integer)
                                && (asmColEntity.TypeColumn == WoTypeColumn.EnumInt)
                            )
                                bDiferente = false;

                            if (
                                (colEntity.TypeColumn == WoTypeColumn.String)
                                && (asmColEntity.TypeColumn == WoTypeColumn.Reference)
                            )
                                bDiferente = false;

                            if (
                                (colEntity.TypeColumn == WoTypeColumn.Long)
                                && (asmColEntity.TypeColumn == WoTypeColumn.Reference)
                            )
                                bDiferente = false;

                            if (
                                (colEntity.TypeColumn == WoTypeColumn.String)
                                && (asmColEntity.TypeColumn == WoTypeColumn.EnumString)
                            )
                                bDiferente = false;

                            if (
                                (colEntity.TypeColumn == WoTypeColumn.Integer)
                                && (asmColEntity.TypeColumn == WoTypeColumn.Autoincrement)
                            )
                                bDiferente = false;

                            if (
                                (colEntity.TypeColumn == WoTypeColumn.Date)
                                && (asmColEntity.TypeColumn == WoTypeColumn.DateTime)
                            )
                                bDiferente = false;

                            if (
                                (colEntity.TypeColumn == WoTypeColumn.DateTime)
                                && (asmColEntity.TypeColumn == WoTypeColumn.Date)
                            )
                                bDiferente = false;

                            if (
                                (colEntity.TypeColumn == WoTypeColumn.Clob)
                                && (asmColEntity.TypeColumn == WoTypeColumn.Complex)
                            )
                                bDiferente = false;

                            if (
                                (colEntity.TypeColumn == WoTypeColumn.Integer)
                                && (asmColEntity.TypeColumn == WoTypeColumn.Smallint)
                            )
                                bDiferente = false;

                            if (
                                (colEntity.TypeColumn == WoTypeColumn.Integer)
                                && (asmColEntity.TypeColumn == WoTypeColumn.Boolean)
                            )
                                bDiferente = false;

                            if (bDiferente)
                                sb.AppendLine(
                                    $"Modelo:{entity.EntityName} Columna:{colEntity.ColumnName} en la base de datos, tipo de columna es:{colEntity.TypeColumn.ToSafeString()} y en el modelo es:{asmColEntity.TypeColumn.ToSafeString()}"
                                );
                        }

                        if (colEntity.Len != asmColEntity.Len)
                        {
                            bool bDiferente = true;
                            if (asmColEntity.TypeColumn == WoTypeColumn.Reference)
                                bDiferente = false;

                            if (asmColEntity.TypeColumn == WoTypeColumn.EnumString)
                                bDiferente = false;

                            if (bDiferente)
                                sb.AppendLine(
                                    $"Modelo:{entity.EntityName} Columna:{colEntity.ColumnName} en la base de datos, la longitud es:{colEntity.Len.ToSafeString()} y en el modelo es:{asmColEntity.Len.ToSafeString()}"
                                );
                        }

                        if (colEntity.Precision != asmColEntity.Precision)
                            sb.AppendLine(
                                $"Modelo:{entity.EntityName} Columna:{colEntity.ColumnName} en la base de datos, la precisión es:{colEntity.Precision.ToSafeString()} y en el modelo es:{asmColEntity.Precision.ToSafeString()}"
                            );
                    }
                    else
                    {
                        sb.AppendLine(
                            $"Modelo:{entity.EntityName} Columna:{colEntity.ColumnName} en la base de datos, no existe en el modelo"
                        );
                    }
                }

                foreach (var colEntity in asmEntity.Columns)
                {
                    if (
                        !entity.Columns.Any(c =>
                            c.ColumnName.ToLower() == colEntity.ColumnName.ToLower()
                        )
                    )
                    {
                        if (
                            (dbProvider == tWoDataBaseProviders.Postgres)
                            && (colEntity.ColumnName.ToLower() == "rowversion")
                        )
                            continue;

                        sb.AppendLine(
                            $"Modelo:{entity.EntityName} Columna:{colEntity.ColumnName} en el modelo, no existe en la base de datos"
                        );
                    }
                }
            }
        }

        private static void CompareSchemaModelIndex(
            List<WoSchemaEntity> entities,
            List<WoSchemaEntity> asmEntities,
            StringBuilder sb
        )
        {
            List<(string, string)> ambos = new List<(string, string)>();

            // Comparar indices que existen en la base de datos y en el modelo
            foreach (WoSchemaEntity entity in entities)
            {
                if (asmEntities.Any(a => a.EntityName.ToLower() == entity.EntityName.ToLower()))
                {
                    WoSchemaEntity asmEntity = asmEntities.FirstOrDefault(e =>
                        e.EntityName.ToLower() == entity.EntityName.ToLower()
                    );

                    foreach (var index in entity.Indexes)
                    {
                        bool bExiste = false;
                        foreach (var asmIndex in asmEntity.Indexes)
                            if (index.IndexText.ToLower() == asmIndex.IndexText.ToLower())
                            {
                                bExiste = true;
                                if (index.Unique != asmIndex.Unique)
                                    sb.AppendLine(
                                        $"Modelo:{entity.EntityName} Indice:{index.IndexText} en la base de datos, es único es:{index.Unique.ToSafeString()} y en el modelo es:{asmIndex.Unique.ToSafeString()}"
                                    );
                                break;
                            }

                        if (!bExiste)
                        {
                            sb.AppendLine(
                                $"Modelo:{entity.EntityName} Indice:{index.IndexText} en la base de datos, no existe en el modelo"
                            );
                        }
                    }
                }
            }

            // Comparar indices que existen en el modelo y en la base de datos
            foreach (WoSchemaEntity asmEentity in asmEntities)
            {
                if (asmEntities.Any(a => a.EntityName.ToLower() == asmEentity.EntityName.ToLower()))
                {
                    WoSchemaEntity entity = entities.FirstOrDefault(e =>
                        e.EntityName.ToLower() == asmEentity.EntityName.ToLower()
                    );

                    foreach (var asmIindex in asmEentity.Indexes)
                    {
                        bool bExiste = false;
                        foreach (var index in entity.Indexes)
                            if (asmIindex.IndexText.ToLower() == index.IndexText.ToLower())
                            {
                                bExiste = true;
                                if (asmIindex.Unique != index.Unique)
                                    sb.AppendLine(
                                        $"Modelo:{asmEentity.EntityName} Indice:{asmIindex.IndexText} en el modelo es, es único es:{asmIindex.Unique.ToSafeString()} y en la base de datos:{index.Unique.ToSafeString()}"
                                    );
                                break;
                            }

                        if (!bExiste)
                        {
                            sb.AppendLine(
                                $"Modelo:{asmEentity.EntityName} Indice:{asmIindex.IndexText} en el modelo, no existe en la base de datos"
                            );
                        }
                    }
                }
            }
        }

        private static void CompareSchemaModelForeing(
            List<WoSchemaEntity> entities,
            List<WoSchemaEntity> asmEntities,
            StringBuilder sb
        )
        {
            List<(string, string)> ambos = new List<(string, string)>();

            // Comparar indices que existen en la base de datos y en el modelo
            foreach (WoSchemaEntity entity in entities)
            {
                if (asmEntities.Any(a => a.EntityName.ToLower() == entity.EntityName.ToLower()))
                {
                    WoSchemaEntity asmEntity = asmEntities.FirstOrDefault(e =>
                        e.EntityName.ToLower() == entity.EntityName.ToLower()
                    );

                    foreach (var foreing in entity.Foreing)
                    {
                        bool bExiste = false;
                        foreach (var asmForeing in asmEntity.Foreing)
                            if (
                                (foreing.Table.ToLower() == foreing.Table.ToLower())
                                && (foreing.From.ToLower() == foreing.From.ToLower())
                                && (foreing.To.ToLower() == foreing.To.ToLower())
                            )
                                bExiste = true;

                        if (!bExiste)
                        {
                            sb.AppendLine(
                                $"Modelo:{entity.EntityName} Llave Foranea Tabla:{foreing.Table} De:{foreing.From} A:{foreing.To} en la base de datos, no existe en el modelo"
                            );
                        }
                    }

                    foreach (var asmForeing in asmEntity.Foreing)
                    {
                        bool bExiste = false;
                        foreach (var foreing in entity.Foreing)
                            if (
                                (foreing.Table.ToLower() == foreing.Table.ToLower())
                                && (foreing.From.ToLower() == foreing.From.ToLower())
                                && (foreing.To.ToLower() == foreing.To.ToLower())
                            )
                                bExiste = true;

                        if (!bExiste)
                        {
                            sb.AppendLine(
                                $"Modelo:{entity.EntityName} Llave Foranea Tabla:{asmForeing.Table} De:{asmForeing.From} A:{asmForeing.To} en el modelo, no existe en la base de datos"
                            );
                        }
                    }
                }
            }
        }
    }
}

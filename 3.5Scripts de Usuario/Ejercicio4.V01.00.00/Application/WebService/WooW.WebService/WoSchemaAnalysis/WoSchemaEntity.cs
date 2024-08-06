using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlTypes;
using System.Text;
using System.Xml.Linq;
using FastMember;
using Org.BouncyCastle.Asn1.X509;
using ServiceStack;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;
using ServiceStack.Text;
using SkiaSharp;
using SqlKata;
using WooW.Core;
using WooW.Core.Common;
using WooW.Core.Server;

namespace WooW.WebService.WoSchemaAnalysis
{
    public class WoSchemaEntity
    {
        public string EntityName { get; set; }

        private List<WoSchemaColumn> _Columns = null;
        public List<WoSchemaColumn> Columns
        {
            get { return _Columns; }
            set { _Columns = value; }
        }

        private List<WoSchemaIndex> _Indexes = null;
        public List<WoSchemaIndex> Indexes
        {
            get { return _Indexes; }
            set { _Indexes = value; }
        }

        private List<WoSchemaForeing> _Foreing = null;
        public List<WoSchemaForeing> Foreing
        {
            get { return _Foreing; }
            set { _Foreing = value; }
        }

        public WoSchemaEntity()
        {
            _Columns = new List<WoSchemaColumn>();
            _Indexes = new List<WoSchemaIndex>();
            _Foreing = new List<WoSchemaForeing>();
        }

        public WoSchemaEntity(
            IDbConnection Db,
            string dbName,
            tWoDataBaseProviders dbProvider,
            string parEntityName
        )
        {
            EntityName = parEntityName;

            LoadColumns(Db, dbName, dbProvider, parEntityName);
            LoadIndexes(Db, dbName, dbProvider, parEntityName);
            LoadForeing(Db, dbName, dbProvider, parEntityName);
        }

        private void LoadColumns(
            IDbConnection Db,
            string dbName,
            tWoDataBaseProviders dbProvider,
            string parEntityName
        )
        {
            _Columns = new List<WoSchemaColumn>();

            string sql = "";

            if (dbProvider == tWoDataBaseProviders.Sqlite)
            {
                // SQLite
                sql = $"PRAGMA table_info({parEntityName})";
            }
            else if (dbProvider == tWoDataBaseProviders.SqlServer)
            {
                // SQL Server (para que se parezca a PRAGMA table_info)
                sql =
                    $@"
WITH TMP_PRIMARIA
     AS (SELECT column_name AS name
         FROM   INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS TC
                INNER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE AS KU
                  ON TC.CONSTRAINT_TYPE = 'PRIMARY KEY'
                     AND TC.CONSTRAINT_NAME = KU.CONSTRAINT_NAME
                     AND KU.table_name = '{parEntityName}'),
     TMP_TABLA
     AS (SELECT COLUMN_NAME AS name,
                COLUMN_DEFAULT AS dflt_value,
                ( CASE
                    WHEN IS_NULLABLE = 'NO' THEN 1
                    ELSE 0
                  END ) AS notnull,
                UPPER(DATA_TYPE) AS TYPE,
                CAST(COALESCE(CHARACTER_MAXIMUM_LENGTH, 0) AS VARCHAR) AS Len,
                CAST(NUMERIC_PRECISION AS VARCHAR) AS PRECISION,
                CAST(NUMERIC_SCALE AS VARCHAR) AS Decimals,
                ordinal_position AS ORDEN
         FROM   INFORMATION_SCHEMA.COLUMNS
         WHERE  table_name = '{parEntityName}')
SELECT TMP_TABLA.name,
       dflt_value,
       notnull,
       ( CASE
           WHEN TMP_PRIMARIA.name IS NULL THEN '0'
           ELSE '1'
         END ) AS pk,
       ( CASE
           WHEN TYPE = 'VARCHAR' and Len = '-1' THEN 'VARCHAR(1000000)'
           WHEN TYPE = 'VARCHAR' THEN 'VARCHAR(' + Len + ')'
           WHEN TYPE = 'DECIMAL' THEN 'DECIMAL(' + PRECISION + ',' + Decimals + ')'
           WHEN TYPE = 'VARBINARY' THEN 'BLOB'
           ELSE TYPE
         END ) AS type
FROM   TMP_TABLA
       LEFT JOIN TMP_PRIMARIA
         ON TMP_TABLA.name = TMP_PRIMARIA.name
ORDER  BY ORDEN 
";
            }
            else if (dbProvider == tWoDataBaseProviders.MySql)
            {
                // MySql (para que se parezca a PRAGMA table_info)
                sql =
                    $@"
SELECT
    COLUMN_NAME AS name,
    (CASE WHEN IS_NULLABLE = 'YES' THEN
    0 ELSE 1 END ) AS notnull,
    CASE WHEN UPPER(DATA_TYPE) = 'VARCHAR' 
    THEN CONCAT(UPPER(DATA_TYPE), '(', CHARACTER_MAXIMUM_LENGTH, ')') 
	 WHEN UPPER(DATA_TYPE) = 'DECIMAL' 
    THEN CONCAT(UPPER(DATA_TYPE), '(', NUMERIC_PRECISION, ',', NUMERIC_SCALE, ')') 
	 WHEN UPPER(DATA_TYPE) = 'LONGTEXT' 
    THEN 'VARCHAR(1000000)' 
	 WHEN UPPER(DATA_TYPE) = 'MEDIUMBLOB' 
    THEN 'BLOB' 
	 ELSE UPPER(DATA_TYPE) END AS type,
    CHARACTER_MAXIMUM_LENGTH AS Len,
    NUMERIC_PRECISION AS ""precision"",
	NUMERIC_SCALE AS Decimals,
	ORDINAL_POSITION AS orden,
	COLUMN_DEFAULT AS dflt_value,
	(CASE WHEN COLUMN_KEY = 'PRI' THEN
    1 ELSE 0 END ) AS pk
FROM INFORMATION_SCHEMA.COLUMNS
WHERE  table_name = '{parEntityName}'
AND    TABLE_SCHEMA = '{dbName}'
ORDER  BY ORDEN ";
            }
            else if (dbProvider == tWoDataBaseProviders.Postgres)
            {
                sql =
                    $@"
WITH tmp_primaria AS (
	SELECT 
		kcu.column_name as primaria
	FROM information_schema.table_constraints tc
	LEFT JOIN information_schema.key_column_usage kcu
		ON tc.constraint_catalog = kcu.constraint_catalog
		AND tc.constraint_schema = kcu.constraint_schema
	 	AND tc.constraint_name = kcu.constraint_name
	 	AND tc.table_name = kcu.table_name
	WHERE tc.constraint_type = 'PRIMARY KEY'
		AND tc.table_name = '{parEntityName}' )
SELECT 
    column_name AS name,
    (CASE WHEN is_nullable = 'YES' THEN
    	0 ELSE 1 END ) AS notnull,
    CASE WHEN data_type = 'character varying'
     	THEN CONCAT('VARCHAR(', CHARACTER_MAXIMUM_LENGTH, ')') 
    WHEN data_type = 'timestamp without time zone'
     	THEN 'DATETIME' 
	WHEN DATA_TYPE = 'numeric' 
     	THEN CONCAT('DECIMAL(', NUMERIC_PRECISION, ',', NUMERIC_SCALE, ')') 
	WHEN UPPER(DATA_TYPE) = 'TEXT' 
     	THEN 'VARCHAR(1000000)' 
	WHEN UPPER(DATA_TYPE) = 'BYTEA' 
     	THEN 'BLOB' 
	ELSE UPPER(DATA_TYPE) END AS type,
    column_default AS dflt_value,
   ( CASE
	   WHEN primaria IS NULL THEN '0'
	   ELSE '1'
	 END ) AS pk
FROM INFORMATION_SCHEMA.COLUMNS ic LEFT JOIN tmp_primaria
ON tmp_primaria.primaria = ic.column_name
WHERE  table_name = '{parEntityName}'
ORDER BY ordinal_position";
            }
            else
                throw new Exception(
                    $"Proveedor {dbProvider.ToString()} no implementado en LoadColumns"
                );

            var columns = Db.SqlList<Dictionary<string, object>>(sql);
            foreach (var column in columns)
            {
                WoSchemaColumn schemaColumn = new WoSchemaColumn();

                object property;
                if (column.TryGetValue("name", out property))
                    schemaColumn.ColumnName = property.ToString();

                if (column.TryGetValue("notnull", out property))
                    schemaColumn.Null = property.ToString() != "1";

                if (column.TryGetValue("pk", out property))
                    schemaColumn.Primary = property.ToString() == "1";

                if (column.TryGetValue("type", out property))
                {
                    string tipo = property.ToString().ToUpper();

                    if ((tipo == "BIT") || (tipo == "BOOLEAN"))
                        schemaColumn.TypeColumn = WoTypeColumn.Boolean;
                    else if ((tipo == "INT") || (tipo == "INTEGER"))
                        schemaColumn.TypeColumn = WoTypeColumn.Integer;
                    else if (tipo == "TINYINT")
                        schemaColumn.TypeColumn = WoTypeColumn.Boolean;
                    else if ((tipo == "BIGINT") || (tipo == "LONG"))
                    {
                        if (schemaColumn.ColumnName.ToLower() == "id")
                            schemaColumn.TypeColumn = WoTypeColumn.Autoincrement;
                        else
                            schemaColumn.TypeColumn = WoTypeColumn.Long;
                    }
                    else if (tipo == "TIMESTAMP") // RowVersion
                        schemaColumn.TypeColumn = WoTypeColumn.Long;
                    else if (tipo.StartsWith("VARCHAR(1000000)"))
                        schemaColumn.TypeColumn = WoTypeColumn.Clob;
                    else if ((tipo == "DATETIME") || (tipo.StartsWith("VARCHAR(8000)")))
                        schemaColumn.TypeColumn = WoTypeColumn.DateTime;
                    else if (tipo.StartsWith("VARCHAR"))
                    {
                        schemaColumn.TypeColumn = WoTypeColumn.String;
                        string longitud = tipo.Substring("VARCHAR(".Length);
                        longitud = longitud.Substring(0, longitud.Length - 1);
                        schemaColumn.Len = longitud.ToInt16();
                    }
                    else if ((tipo == "REAL") || (tipo == "FLOAT"))
                        schemaColumn.TypeColumn = WoTypeColumn.Double;
                    else if (tipo == "BLOB")
                        schemaColumn.TypeColumn = WoTypeColumn.Blob;
                    else if (tipo.StartsWith("DECIMAL"))
                    {
                        schemaColumn.TypeColumn = WoTypeColumn.Decimal;
                        string longitud = tipo.Substring("DECIMAL(".Length);
                        string decimales = longitud.Substring(0, longitud.IndexOf(","));
                        schemaColumn.Len = decimales.ToInt16();
                        string precision = longitud.Substring(longitud.IndexOf(",") + 1);
                        precision = precision.Substring(0, precision.Length - 1);
                        schemaColumn.Precision = precision.ToInt16();
                    }
                    else if (tipo.StartsWith("DOUBLE"))
                    {
                        schemaColumn.TypeColumn = WoTypeColumn.Double;
                        schemaColumn.Len = 0;
                        schemaColumn.Precision = 0;
                    }
                    else
                        throw new Exception("Tipo de columna no soportado: " + tipo);

                    if (column.TryGetValue("dflt_value", out property))
                        if (property != null)
                        {
                            if (property.ToString() != "NULL")
                            {
                                property = property
                                    .ToString()
                                    .Replace("((", "")
                                    .Replace("))", "")
                                    .Replace("000000", "0");

                                if (
                                    (schemaColumn.TypeColumn == WoTypeColumn.Decimal)
                                    && (dbProvider != tWoDataBaseProviders.Sqlite)
                                )
                                {
                                    property += "m";
                                }

                                schemaColumn.Default = property.ToString();
                            }
                        }
                }

                _Columns.Add(schemaColumn);
            }
        }

        public WoSchemaEntity(
            Type parEntityType,
            string dbName,
            tWoDataBaseProviders dbProvider,
            string parEntityName
        )
        {
            EntityName = parEntityName;

            var Accesor = TypeAccessor.Create(parEntityType);

            LoadColumnsFromType(parEntityType, dbName, dbProvider, Accesor);
            LoadIndexesFromType(parEntityType, dbName, dbProvider, Accesor);
            LoadForeingFromType(parEntityType, dbName, dbProvider, Accesor);
        }

        public void LoadColumnsFromType(
            Type parEntityType,
            string dbName,
            tWoDataBaseProviders dbProvider,
            TypeAccessor Accesor
        )
        {
            _Columns = new List<WoSchemaColumn>();

            foreach (Member member in Accesor.GetMembers())
            {
                WoSchemaColumn schemaColumn = new WoSchemaColumn();

                if (member.Name.StartsWith("_")) // Calc
                    continue;

                schemaColumn.ColumnName = member.Name;

                WoReferenceBaseAttribute collection = (WoReferenceBaseAttribute)
                    member.GetAttribute(typeof(WoReferenceBaseAttribute), true);

                if (collection != null)
                    continue;

                WoColumnMetaAttribute columnMeta = (WoColumnMetaAttribute)
                    member.GetAttribute(typeof(WoColumnMetaAttribute), true);

                if (columnMeta == null)
                    continue;

                schemaColumn.Default = columnMeta.Default;
                schemaColumn.Null = columnMeta.Nulo;
                schemaColumn.Primary = columnMeta.Primaria;
                schemaColumn.TypeColumn = columnMeta.TipoColumna;
                schemaColumn.Len = columnMeta.Longitud;
                schemaColumn.Precision = columnMeta.Precision;

                _Columns.Add(schemaColumn);
            }
        }

        private void LoadIndexes(
            IDbConnection Db,
            string dbName,
            tWoDataBaseProviders dbProvider,
            string parEntityName
        )
        {
            _Indexes = new List<WoSchemaIndex>();

            string sql = "";

            if (dbProvider == tWoDataBaseProviders.Sqlite)
            {
                // SQLite
                sql = $"PRAGMA index_list({parEntityName})";
            }
            else if (dbProvider == tWoDataBaseProviders.SqlServer)
            {
                sql =
                    $@"SELECT i.[name] AS name,
       --(case when cast(i.is_unique as varchar) = '0' then '1' else '0' end) AS [unique],
        cast(i.is_unique as varchar) AS [unique],
       'C' AS origin
FROM   sys.objects t
       INNER JOIN sys.indexes i
         ON t.object_id = i.object_id
WHERE  t.is_ms_shipped <> 1
       AND index_id > 0
       AND t.[name] = '{parEntityName}'
ORDER  BY 1 
";
            }
            else if (dbProvider == tWoDataBaseProviders.MySql)
            {
                sql =
                    $@"SELECT DISTINCT
    INDEX_NAME AS name,
    (CASE WHEN NON_UNIQUE = 0 THEN 1 ELSE 0 END) AS 'unique',
    'C' AS origin
FROM INFORMATION_SCHEMA.STATISTICS
WHERE
NOT INDEX_NAME LIKE 'FK_%'
AND table_name = '{parEntityName}'
AND TABLE_SCHEMA = '{dbName}'";
            }
            else if (dbProvider == tWoDataBaseProviders.Postgres)
            {
                sql =
                    $@"select 
    cast(i.indexrelid::regclass as varchar) as name,
    (case when i.indisunique then 1 else 0 end) as ""unique"",
	'C' AS origin
from pg_index i
join pg_class c on c.oid = i.indrelid
where c.relname = '{parEntityName}'";
            }
            else
                throw new Exception(
                    $"Proveedor {dbProvider.ToString()} no implementado en LoadIndexes"
                );

            var columns = Db.SqlList<Dictionary<string, object>>(sql);

            foreach (var column in columns)
            {
                object property;

                string IndexName = "";
                if (column.TryGetValue("name", out property))
                    IndexName = property.ToString();

                bool Unique = false;
                if (column.TryGetValue("unique", out property))
                    Unique = property.ToString() == "1";

                string Origin = "";
                if (column.TryGetValue("origin", out property))
                    Origin = property.ToString();

                WoSchemaIndex schemaIndex = new WoSchemaIndex(
                    Db,
                    dbName,
                    dbProvider,
                    parEntityName,
                    IndexName,
                    Unique,
                    Origin
                );

                // Si es un indice unico, no agregar el indice de la columna autoincrement (sql server la agrega pero sqlite no)
                if (Unique && (dbProvider != tWoDataBaseProviders.Sqlite))
                {
                    bool autoincrement = false;
                    foreach (var indexColumn in schemaIndex.IndexColumn)
                    {
                        if (
                            _Columns.Any(columnEntity =>
                                columnEntity.ColumnName == indexColumn.ColumnName
                                && columnEntity.TypeColumn == WoTypeColumn.Autoincrement
                            )
                        )
                        {
                            autoincrement = true;
                            break;
                        }
                    }

                    if (autoincrement)
                        continue;
                }

                _Indexes.Add(schemaIndex);
            }
        }

        public void LoadIndexesFromType(
            Type parEntityType,
            string dbName,
            tWoDataBaseProviders dbProvider,
            TypeAccessor Accesor
        )
        {
            _Indexes = new List<WoSchemaIndex>();

            // Primary
            foreach (Member member in Accesor.GetMembers())
            {
                WoColumnMetaAttribute columnMeta = (WoColumnMetaAttribute)
                    member.GetAttribute(typeof(WoColumnMetaAttribute), true);

                if (columnMeta == null)
                    continue;

                if (columnMeta.Primaria)
                {
                    if (columnMeta.TipoColumna == WoTypeColumn.Autoincrement)
                        continue;

                    WoSchemaIndex schemaIndex = new WoSchemaIndex()
                    {
                        IndexName = "PK_" + EntityName,
                        Unique = true,
                        Origin = "pk"
                    };

                    schemaIndex.IndexColumn.Add(
                        new WoSchemaIndexColumn()
                        {
                            ColumnName = member.Name,
                            Order = WoSchemaIndexColumn.WoOrder.Asc,
                            Row = 0
                        }
                    );

                    _Indexes.Add(schemaIndex);
                    break;
                }
            }

            //GuidId Asc en la base de datos, no existe en el modelo
            foreach (Member member in Accesor.GetMembers())
            {
                if (member.Name == "GuidId")
                {
                    WoSchemaIndex schemaIndex = new WoSchemaIndex()
                    {
                        IndexName = "IN_" + EntityName,
                        Unique = true,
                        Origin = "in"
                    };

                    schemaIndex.IndexColumn.Add(
                        new WoSchemaIndexColumn()
                        {
                            ColumnName = member.Name,
                            Order = WoSchemaIndexColumn.WoOrder.Asc,
                            Row = 0
                        }
                    );

                    _Indexes.Add(schemaIndex);
                    break;
                }
            }

            var CompositeIndexes = parEntityType.GetCustomAttributes(
                typeof(CompositeIndexAttribute),
                true
            );

            foreach (CompositeIndexAttribute compositeIndex in CompositeIndexes)
            {
                WoSchemaIndex schemaIndex = new WoSchemaIndex()
                {
                    IndexName = compositeIndex.Name,
                    Unique = compositeIndex.Unique,
                    Origin = "C"
                };

                int row = 0;
                foreach (string column in compositeIndex.FieldNames)
                {
                    schemaIndex.IndexColumn.Add(
                        new WoSchemaIndexColumn()
                        {
                            ColumnName = column,
                            Order = WoSchemaIndexColumn.WoOrder.Asc,
                            Row = row++
                        }
                    );
                }

                _Indexes.Add(schemaIndex);
            }
        }

        private void LoadForeing(
            IDbConnection Db,
            string dbName,
            tWoDataBaseProviders dbProvider,
            string parEntityName
        )
        {
            _Foreing = new List<WoSchemaForeing>();

            string sql = "";

            if (dbProvider == tWoDataBaseProviders.Sqlite)
            {
                // SQLite
                sql = $"PRAGMA foreign_key_list({parEntityName})";

                //"table"
                //"from"
                //"to"
            }
            else if (dbProvider == tWoDataBaseProviders.SqlServer)
            {
                sql =
                    $@"
SELECT 
    OBJECT_NAME(fk.referenced_object_id) AS 'table',
    c1.name AS 'from',
    c2.name AS 'to'
FROM 
    sys.foreign_keys AS fk
INNER JOIN 
    sys.foreign_key_columns AS fkc ON fk.object_id = fkc.constraint_object_id
INNER JOIN 
    sys.columns AS c1 ON fkc.parent_column_id = c1.column_id AND fkc.parent_object_id = c1.object_id
INNER JOIN 
    sys.columns AS c2 ON fkc.referenced_column_id = c2.column_id AND fkc.referenced_object_id = c2.object_id
WHERE 
	OBJECT_NAME(fk.parent_object_id) = '{parEntityName}'
ORDER BY 
    1, 2, 3";
            }
            else if (dbProvider == tWoDataBaseProviders.MySql)
            {
                sql =
                    $@"
SELECT 
    REFERENCED_TABLE_NAME AS 'Table',
    COLUMN_NAME AS 'From',
    REFERENCED_COLUMN_NAME AS 'To'
FROM 
    INFORMATION_SCHEMA.KEY_COLUMN_USAGE
WHERE 
    CONSTRAINT_SCHEMA = '{dbName}' AND
    REFERENCED_TABLE_NAME IS NOT NULL AND
    TABLE_NAME = '{parEntityName}' AND
    TABLE_SCHEMA = '{dbName}'
ORDER BY 
    1, 2, 3";
            }
            else if (dbProvider == tWoDataBaseProviders.Postgres)
            {
                sql =
                    $@"
SELECT
	ccu.table_name AS ""Table"",
    kcu.column_name AS ""From"",
    ccu.column_name AS ""To""
FROM 
    information_schema.table_constraints AS tc
JOIN 
    information_schema.key_column_usage AS kcu 
    ON tc.constraint_name = kcu.constraint_name
JOIN 
    information_schema.constraint_column_usage AS ccu 
    ON ccu.constraint_name = tc.constraint_name
WHERE 
    tc.constraint_type = 'FOREIGN KEY'
	and tc.table_name = '{parEntityName}'
ORDER BY 
    tc.table_name, tc.constraint_name";
            }
            else
                throw new Exception(
                    $"Proveedor {dbProvider.ToString()} no implementado en LoadIndexes"
                );

            var columns = Db.SqlList<Dictionary<string, object>>(sql);
            foreach (var column in columns)
            {
                object property;

                string table = "";
                if (column.TryGetValue("table", out property))
                    table = property.ToString();

                string from = "";
                if (column.TryGetValue("from", out property))
                    from = property.ToString();

                string to = "";
                if (column.TryGetValue("to", out property))
                    to = property.ToString();

                WoSchemaForeing schemaForeing = new WoSchemaForeing()
                {
                    Table = table,
                    From = from,
                    To = to
                };

                _Foreing.Add(schemaForeing);
            }
        }

        public void LoadForeingFromType(
            Type parEntityType,
            string dbName,
            tWoDataBaseProviders dbProvider,
            TypeAccessor Accesor
        )
        {
            _Foreing = new List<WoSchemaForeing>();

            // Primary
            foreach (Member member in Accesor.GetMembers())
            {
                WoColumnMetaAttribute columnMeta = (WoColumnMetaAttribute)
                    member.GetAttribute(typeof(WoColumnMetaAttribute), true);

                if (columnMeta == null)
                    continue;

                if (
                    (columnMeta.TipoColumna == WoTypeColumn.Reference)
                    && (!member.Type.IsGeneric())
                    && (member.Type.Name != "IList`1")
                )
                {
                    WoSchemaForeing schemaForeing = new WoSchemaForeing()
                    {
                        Table = columnMeta.ModeloId,
                        From = member.Name,
                        To = "Id"
                    };

                    _Foreing.Add(schemaForeing);
                }
            }
        }
    }

    public class WoSchemaColumn
    {
        public int Row { get; set; }

        public string ColumnName { get; set; }

        public string Default { get; set; }

        public int Len { get; set; }

        public int Precision { get; set; }

        public WoTypeColumn TypeColumn { get; set; }

        public bool Primary { get; set; }

        public bool Null { get; set; }

        public WoSchemaColumn() { }
    }

    public class WoSchemaIndex
    {
        public string IndexName { get; set; }
        public bool Unique { get; set; }

        public string Origin { get; set; }

        private List<WoSchemaIndexColumn> _IndexColumn = null;
        public List<WoSchemaIndexColumn> IndexColumn
        {
            get { return _IndexColumn; }
            set { _IndexColumn = value; }
        }

        public string IndexText
        {
            get
            {
                string index = "";
                foreach (var column in _IndexColumn)
                {
                    if (index != "")
                        index += ", ";
                    index += column.ColumnName + " " + column.Order.ToString();
                }
                return index;
            }
        }

        public WoSchemaIndex()
        {
            _IndexColumn = new List<WoSchemaIndexColumn>();
        }

        public WoSchemaIndex(
            IDbConnection Db,
            string dbName,
            tWoDataBaseProviders dbProvider,
            string parEntityName,
            string parIndexName,
            bool parUnique,
            string parOrigin
        )
        {
            IndexName = parIndexName;
            Unique = parUnique;
            Origin = parOrigin;

            _IndexColumn = new List<WoSchemaIndexColumn>();

            string sql = "";

            if (dbProvider == tWoDataBaseProviders.Sqlite)
            {
                sql = $"PRAGMA index_xinfo({parIndexName})";
            }
            else if (dbProvider == tWoDataBaseProviders.SqlServer)
            {
                sql =
                    $@"
SELECT cols.name name,
       ind.name indice,
       ind.type_desc tipo,
	   ind_cols.key_ordinal AS seqno,
	   (CASE WHEN CAST(ind_cols.is_descending_key AS varchar) = '0' THEN 0 ELSE 1 END) AS [desc]
FROM   sys.columns cols,
       sys.indexes ind,
       sys.index_columns ind_cols
WHERE  cols.object_id = ind.object_id
       AND cols.object_id = ind_cols.object_id
       AND cols.column_id = ind_cols.column_id
       AND ind.index_id = ind_cols.index_id
	   AND ind.name = '{parIndexName}'
ORDER  BY ind.name,
          ind_cols.key_ordinal 
";
            }
            else if (dbProvider == tWoDataBaseProviders.MySql)
            {
                sql =
                    $@"
SELECT 
COLUMN_NAME AS name,
SEQ_IN_INDEX AS seqno,
CASE WHEN COLLATION = 'A' THEN 0 ELSE 1 END 'desc'
FROM INFORMATION_SCHEMA.STATISTICS
WHERE 
TABLE_NAME = '{parEntityName}' 
AND INDEX_NAME = '{parIndexName}'
AND TABLE_SCHEMA = '{dbName}'";
            }
            else if (dbProvider == tWoDataBaseProviders.Postgres)
            {
                sql =
                    $@"
select
    a.attname as name,
	a.attnum as seqno,
	0 as desc
from
    pg_class t,
    pg_class i,
    pg_index ix,
    pg_attribute a
where
    t.oid = ix.indrelid
    and i.oid = ix.indexrelid
    and a.attrelid = t.oid
    and a.attnum = ANY(ix.indkey)
    and t.relkind = 'r'
    and t.relname like '{parEntityName}'
    and i.relname like '{parIndexName}'
order by
    t.relname,
    i.relname,
	a.attnum";
            }
            else
                throw new Exception(
                    $"Proveedor {dbProvider.ToString()} no implementado en WoSchemaIndex"
                );

            var columns = Db.SqlList<Dictionary<string, object>>(sql);

            Dictionary<int, Dictionary<string, object>> columnNoSorted =
                new Dictionary<int, Dictionary<string, object>>();

            foreach (var column in columns)
            {
                object property;

                int seqno = 0;
                if (column.TryGetValue("seqno", out property))
                    seqno = property.ToInt16();

                columnNoSorted.Add(seqno, column);
            }

            Dictionary<int, Dictionary<string, object>> columnSorted = columnNoSorted
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var dicColumn in columnSorted)
            {
                var column = dicColumn.Value;

                WoSchemaIndexColumn indexColumn = new WoSchemaIndexColumn();

                object property;

                if (column.TryGetValue("seqno", out property))
                    indexColumn.Row = property.ToInt16();

                if (column.TryGetValue("name", out property))
                {
                    if (property == null)
                        continue;
                    indexColumn.ColumnName = property.ToSafeString();
                }

                if (column.TryGetValue("desc", out property))
                    indexColumn.Order = (
                        property.ToSafeString() == "0"
                            ? WoSchemaIndexColumn.WoOrder.Asc
                            : WoSchemaIndexColumn.WoOrder.Desc
                    );

                _IndexColumn.Add(indexColumn);
            }
        }
    }

    public class WoSchemaIndexColumn
    {
        public enum WoOrder
        {
            Asc,
            Desc
        }

        public string ColumnName { get; set; }

        public WoOrder Order { get; set; }

        public int Row { get; set; }

        public WoSchemaIndexColumn() { }
    }

    public class WoSchemaForeing
    {
        public string Table { get; set; }
        public string From { get; set; }

        public string To { get; set; }

        public WoSchemaForeing() { }
    }
}

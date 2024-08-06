using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ServiceStack;
using ServiceStack.OrmLite;
using WooW.Core.Common;
using WooW.Core.Server;

namespace WooW.ServiceInterface
{
    public class WoDataBaseOperationsService : Service
    {
        public string Any(WoDataBaseOperations dbOperation)
        {
            try
            {
                var builder = new ConfigurationBuilder().AddJsonFile(
                    Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json")
                );
                IConfiguration Configuration = builder.Build();

                if (dbOperation.Accion == tWoDataBaseAccion.Create)
                {
                    WoDataBaseOperations.CreateDataBase(Configuration, dbOperation.DataBaseName);
                    return $"Base de datos {dbOperation.DataBaseName} creada";
                }
                else if (dbOperation.Accion == tWoDataBaseAccion.Drop)
                {
                    WoDataBaseOperations.DropDataBase(Configuration, dbOperation.DataBaseName);
                    return $"Base de datos {dbOperation.DataBaseName} eliminada";
                }
                else if (dbOperation.Accion == tWoDataBaseAccion.Backup)
                {
                    WoDataBaseOperations.BackupDataBase(
                        Configuration,
                        dbOperation.DataBaseName,
                        dbOperation.BackupName
                    );
                    return $"Base de datos {dbOperation.DataBaseName} respaldada";
                }
                else if (dbOperation.Accion == tWoDataBaseAccion.Restore)
                {
                    WoDataBaseOperations.RestoreDataBase(
                        Configuration,
                        dbOperation.DataBaseName,
                        dbOperation.BackupName
                    );
                    return $"Base de datos {dbOperation.DataBaseName} restaurada";
                }
                else if (dbOperation.Accion == tWoDataBaseAccion.ListBackup)
                {
                    return WoDataBaseOperations.ListBackup(Configuration, dbOperation.DataBaseName);
                }
                else
                {
                    return "Operación no válida";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }
}

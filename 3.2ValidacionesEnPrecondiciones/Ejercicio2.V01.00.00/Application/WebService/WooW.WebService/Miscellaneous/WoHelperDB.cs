﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using ServiceStack;
using ServiceStack.OrmLite;
using ServiceStack.Text;
using ServiceStack.Web;
using WooW.Core;
using WooW.Core.Common;
using WooW.Core.Server;
using WooW.DTO;
using WooW.Model;

#if SERVER
namespace WooW.Model
{
    public static class WoHelperDB
    {
        public static void OnCreateExcepcion(
            IDbConnection Db,
            tWoIntanciaType IntanciaType,
            tWoDataBaseProviders DbProvider,
            string Error
        )
        {
            if (DbProvider == tWoDataBaseProviders.Postgres)
            {
                string sql = Db.GetLastSql();
                sql = sql.Replace(
                    "\"id\"  PRIMARY KEY,",
                    "\"id\" BIGINT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY, "
                );
                sql = sql.Replace(
                    "BOOLEAN NOT NULL DEFAULT (0),",
                    "BOOLEAN NOT NULL DEFAULT (false),"
                );
                sql = sql.Replace(
                    "BOOLEAN NOT NULL DEFAULT (1),",
                    "BOOLEAN NOT NULL DEFAULT (true),"
                );
                sql = sql.Replace("BOOLEAN NULL DEFAULT (0),", "BOOLEAN NULL DEFAULT (false),");
                sql = sql.Replace("BOOLEAN NULL DEFAULT (1),", "BOOLEAN NULL DEFAULT (true),");
                Db.ExecuteNonQuery(sql);
            }
            else
                throw new Exception(Error);
        }
    }
}
#endif
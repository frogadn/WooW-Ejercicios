using System.Data;
using System.Text.RegularExpressions;
using Funq;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Org.BouncyCastle.Asn1.X500;
using Org.BouncyCastle.Asn1.X509;
using ServiceStack;
//using Quartz;
using ServiceStack.Admin;
using ServiceStack.Api.OpenApi;
using ServiceStack.Auth;
using ServiceStack.Data;
using ServiceStack.Host;
using ServiceStack.OrmLite;
using ServiceStack.Text;
//using ServiceStack.Quartz;
using ServiceStack.Validation;
using ServiceStack.Web;
using WooW.Core;
using WooW.Core.Common;
using WooW.Core.Server;
using WooW.Model;
using WooW.Resources.Comments;
using WooW.Resources.Labels;
using WooW.Resources.Messages;
using WooW.ServiceInterface;
using WooW.WebService.WoSchemaAnalysis;

//using ConnectionInfo = ServiceStack.ConnectionInfo;

[assembly: HostingStartup(typeof(WooW.AppHost))]

namespace WooW;

public partial class AppHost : AppHostBase, IHostingStartup
{
    public IConfiguration Configuration { get; }

    public void Configure(IWebHostBuilder builder) =>
        builder.ConfigureServices(services =>
        {
            // Configure ASP.NET Core IOC Dependencies
            // services.AddSingleton<IConfiguration>(Configuration);
        });

    public AppHost()
        : base(
            "WooW",
            new System.Reflection.Assembly[]
            {
                typeof(AppHost).Assembly,
                typeof(WoInstanciaUdnServices).Assembly
            }
        )
    {
        var builder = new ConfigurationBuilder().AddJsonFile(
            Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json")
        );
        Configuration = builder.Build();
    }

    public string GetWooW_Label(string label)
    {
        return WooW_Label.ResourceManager.GetString(label, WooW_Label.Culture);
    }

    public string GetWooW_Comment(string label)
    {
        return WooW_Comment.ResourceManager.GetString(label, WooW_Label.Culture);
    }

    public string GetWooW_Message(string label)
    {
        return WooW_Message.ResourceManager.GetString(label, WooW_Label.Culture);
    }

    public override void Configure(Container container)
    {
        // Configura delegados de errores y mesnsajes
        WoGetExcepcion.GetWooW_Label = GetWooW_Label;
        WoScriptingException.GetWooW_Comment = GetWooW_Comment;
        WoScriptingException.GetWooW_Message = GetWooW_Message;

        // Configure ServiceStack only IOC, Config & Plugins
        SetConfig(
            new HostConfig
            {
                UseSameSiteCookies = true
                //, DebugMode = AppSettings.Get(nameof(HostConfig.DebugMode), false)
            }
        );

        Plugins.Add(new ValidationFeature());

        //Plugins.Add(new CorsFeature(allowedOrigins: "*",
        //    allowedMethods: "GET, POST, PUT, DELETE, OPTIONS",
        //    allowedHeaders: "Content-Type,Authorization",
        //    allowCredentials: true));
        // Remplazado por la siguientes lineas

        Plugins.Add(
            new CorsFeature(
                allowOriginWhitelist: new[] { "*" },
                allowedMethods: "GET, POST, PATCH, PUT, DELETE, OPTIONS",
                allowedHeaders: "Content-Type, Allow, Authorization",
                allowCredentials: true
            )
        );

        PreRequestFilters.Add(
            (httpReq, httpRes) =>
            {
                string origin = httpReq.Headers.Get("Origin");
                if (origin != null)
                    httpRes.AddHeader(HttpHeaders.AllowOrigin, origin);
                else
                    httpRes.AddHeader(HttpHeaders.AllowOrigin, "https://localhost:5101");
            }
        );

        PreRequestFilters.Add(
            (httpReq, httpRes) =>
            {
                if (httpReq.Verb == "OPTIONS")
                {
                    httpRes.EndRequest();
                }
            }
        );

        Plugins.Add(new AutoQueryFeature { MaxLimit = 1000 });

        Plugins.Add(new AdminUsersFeature());

        //Plugins.Add(new EncryptedMessagesFeature
        //{
        //    PrivateKeyXml =
        //        @"<RSAKeyValue><Modulus>2qZgVRx6Y2Kqcu/nHiDovfjdHG9LQZ3pL26qtFFCiwWIGzVGtWdrFvcAPpTyE1vKuEwm+RaOxD2AmUi13U+p51wCOaFwZpflL2Ak74/SujW0J6qyJQnPjbMQNb4utEtO9Yv49kN5w7K/PAQ711IIXXjPG2OCJ6K2b9np7wzXwdQvRhNSo87YjXjgqn4zHx9nlKanGO4vBBN5RKW2sMyBCoyBXSFxFU0HCI2sn16hktrpguF5y8PGaw9Wlbo1llP3RFdIzb/8E9+LuMJ7iTbVy/jII2q6UumDGnPPCljxj4nizaIU6dJzStbX22JbXjuefNAtZtx2fjK8U7YUS+xcMQ==</Modulus><Exponent>AQAB</Exponent><P>/BCLpIN8NADN5/3FWtpEUq3nBIbm78qjYYi1puPZ5LHgvxIIBKfGDkzs+a6BfEnZvnSk5CI2aWAoqnC6x6fM2OThbqv8ZmXa+W5kwNVCXWmmiYNxHKlPP5PuwW5KcyJ4VpIO26mrcT/c8ORqVDE3Gcv4AGmmvfgcuoAHE8VPivM=</P><Q>3hBHTE26RD7dxpZNP8ZaB9bI2Oy0EPVvHxrsRIqQTaSRF0+GHseW4nTt9YofkUN7u25bBcBWExRUyZXWwY3eYsBzOQXDaPbVTTaxPLeH6w4Nu3tmtuSO3pWFAqLAefM1iBDV/nBtKniuiKs1OX993pxV3ktasVmScd7AEaOifUs=</Q><DP>NA2+qMS2e47G9ufDP9XfUiuzj43EVzTDtLqkuMhJER9iyFKS8VMsZXuhXJabCu29V8WC39Ho5q4C99+70stmVEw/+bjusL7MD8Kqb+AaimvtBmzsiPy17u0/2xZJrakqrMYQ53AMhaCood6pzqUzOdKTbpJi6sw4MpOJ4p1Wpd0=</DP><DQ>hQp7rNtknT6M4E1sOqk7hzbHXi9yMjbZPGmE5AugKORPiQe78vThEQu9BT6bawxjNQgIwIlbCFNF+QAsignVEpT6c09go6I+aOQ7i4TpiYoB8DEeeLS2Y+RwrAOWDXoIuFxd2PLCdI+ZAYiResFHR/eh+mxrCZYAhvhNWkQPNcE=</DQ><InverseQ>VKSE6cFaMkrVw1CoRmyO0Eq2YtrxTs9kM84lhdV1YZLL8wqVw1Sq8SYPoEtiU48jJKZ0HnFRd9cgKLzMbDLdcgmvAVdyWp4FFvEQdTPaZ6sK6C0HDRYU78gg+NADjIRN0PKpU0H9SarNEbNvMHcUU/D7JzRnVzdW631/TNllWek=</InverseQ><D>h09A/ErUXp7XlqtqHpYFElNpGkixjNjZTrYww8gp4vi4YwYUTPzEJAEVUKVCLcK3cFgIIkvYbA8Xf0Sk72F2Zqvk4J9MfODxPuFD2lDp+rxzUbzr48nvfORcWrXoF0EniwNlPZlCSF5cxBpmofitHpM9r9hj2n1yY0O65mnPN64fbR8rqnUL2/npTkClrVvVppR1827HieQD+Tjs15cY15JNT8S338H1Nykz1tnpOYV7L7kaIxxJFGLxjuB/1I13Fo88/qQJCBAjsmojyUuwJn8DnWWflD9Z5168a83hLTyAA6b5N0Xt5yXnJAFY4VMbgkOlyaEfDmgYdV5LzYFW5Q==</D></RSAKeyValue>"
        //});


        Plugins.Add(new OpenApiFeature());

        Plugins.Add(new SessionFeature());

        this.GetPlugin<MetadataFeature>().AddPluginLink("swagger-ui/", "Swagger UI");

        //container.AddSingleton<IODataToSqlConverter, ODataToSqlConverter>();

        container.AddSingleton<ICrudEvents>(c => new OrmLiteCrudEvents(
            c.Resolve<IDbConnectionFactory>()
        ));
        container.Resolve<ICrudEvents>().InitSchema();

        RegisterTypedRequestFilter<IWoInstanciaUdnAsignar>(
            (req, res, dto) =>
            {
                SetInstanciaUDN(dto, req, container);
            }
        );

        string LogFile = "";
        string DataBaseName = "";
        tWoDataBaseProviders DbProvider = tWoDataBaseProviders.Sqlite;
        tWoIntanciaType IntanciaType = tWoIntanciaType.DEV;

        var dbFactory = container.Resolve<IDbConnectionFactory>() as OrmLiteConnectionFactory;

        dbFactory.RegisterDialectProvider(
            tWoDataBaseProviders.Sqlite.ToString(),
            SqliteDialect.Provider
        );
        dbFactory.RegisterDialectProvider(
            tWoDataBaseProviders.SqlServer.ToString(),
            SqlServer2019Dialect.Provider
        );
        dbFactory.RegisterDialectProvider(
            tWoDataBaseProviders.MySql.ToString(),
            MySqlDialect.Provider
        );

        IOrmLiteDialectProvider DbPostgreProvider = PostgreSqlDialect.Provider;
        DbPostgreProvider.NamingStrategy = new MyPostgreSqlNamingStrategy(); // Quita los subguiones de postgres
        dbFactory.RegisterDialectProvider(
            tWoDataBaseProviders.Postgres.ToString(),
            DbPostgreProvider
        );

        var SqlDatabaseType = Configuration.GetValue<string>(
            "WooWSettings:SqlDatabase",
            tWoDataBaseProviders.SqlServer.ToString()
        );

        if (
            (SqlDatabaseType != tWoDataBaseProviders.SqlServer.ToString())
            && (SqlDatabaseType != tWoDataBaseProviders.MySql.ToString())
            && (SqlDatabaseType != tWoDataBaseProviders.Postgres.ToString())
        )
            throw new Exception(
                $"El tipo de base de datos {SqlDatabaseType} no es valido, valores admitidos en WooWSettings:SqlDatabase son: {tWoDataBaseProviders.SqlServer.ToString()}, {tWoDataBaseProviders.MySql.ToString()} y {tWoDataBaseProviders.Postgres.ToString()}"
            );

        RegisterTypedRequestFilter<IWoInstanciaUdn>(
            (req, res, dto) =>
                req.Items[Keywords.DbInfo] = new ServiceStack.ConnectionInfo
                {
                    ConnectionString = GetDBConnString(
                        dto,
                        req,
                        container,
                        out LogFile,
                        out IntanciaType,
                        out DataBaseName,
                        out DbProvider
                    ),
                    ProviderName = (
                        GetProviderName(req) == tWoIntanciaType.DEV
                            ? tWoDataBaseProviders.Sqlite.ToString()
                            : (
                                SqlDatabaseType == tWoDataBaseProviders.SqlServer.ToString()
                                    ? tWoDataBaseProviders.SqlServer.ToString()
                                    : (
                                        SqlDatabaseType == tWoDataBaseProviders.MySql.ToString()
                                            ? tWoDataBaseProviders.MySql.ToString()
                                            : tWoDataBaseProviders.Postgres.ToString()
                                    )
                            )
                    )
                }
        );

        ConfigurePlugin<UiFeature>(feature => feature.AdminUi &= ~(AdminUiFeature.All));

        /*
        var quartzFeature = new QuartzFeature();

        // create a simple job trigger to repeat every minute
        quartzFeature.RegisterJob<MyJob>(
            trigger =>
                trigger.WithSimpleSchedule(s =>
                        s.WithInterval(TimeSpan.FromMinutes(1))
                            .RepeatForever()
                    )
                    .Build()
        );

        // register the plugin
        Plugins.Add(quartzFeature);
        */

        //this.SetConfig(new HostConfig
        //{
        //    DefaultContentType = MimeTypes.Json
        //});

        //this.SetConfig(new HostConfig
        //{
        //    EnableFeatures = Feature.All.Remove(Feature.Html),
        //});
    }

    public string SetInstanciaUDN(IWoInstanciaUdnAsignar dto, IRequest req, Container container)
    {
        if (dto.Instance.IsNullOrStringEmpty())
            throw new Exception("Instancia no puede ser nulo o vacio");

        if (
            !Regex.IsMatch(
                dto.Instance,
                "^[A-Z&�]{3,4}[0-9]{2}(0[1-9]|1[012])(0[1-9]|[12][0-9]|3[01])[A-Z0-9]{2}[0-9A]$"
            )
        )
            throw new Exception("Instancia no es RFC valido");

        if ((dto.Year < 2020) || (dto.Year > 2030))
            throw new Exception("A�o incorrecto debe estar entre 2020 y 2030");

        var jwtProvider = AuthenticateService.GetJwtAuthProvider();

        AuthUserSession session = new AuthUserSession();

        var token = req.GetBearerToken();

        if (token != null)
        {
            if (jwtProvider.IsJwtValid(token))
            {
                JsonObject payload = jwtProvider.GetValidJwtPayload(token);
                session.Id = payload["SessionId"];
                session.UserAuthName = payload["email"];
                session.UserAuthId = payload["UserAuthId"];
                var tok = token;
            }
            else
            {
                throw new Exception($"El token de autenticacion no es valido");
            }
        }
        else
        {
            throw new Exception($"No se puede recuperar el token de autenticacion");
        }

        string sessionKey = session.Id;

        var InstanciaUDNKey = new Tuple<string, string>(session.UserAuthName, session.Id);

        if (!Directory.Exists($"{System.AppDomain.CurrentDomain.BaseDirectory}DBService"))
            Directory.CreateDirectory($"{System.AppDomain.CurrentDomain.BaseDirectory}DBService");
        string sConnString =
            $"data source = {System.AppDomain.CurrentDomain.BaseDirectory}DBService\\WooW.DB.Config.sqlite;foreign keys = true;";

        var dbFactory = new OrmLiteConnectionFactory(sConnString, SqliteDialect.Provider);
        var localDb = dbFactory.Open();

        List<string> Roles = localDb.Column<string>(
            localDb
                .From<UserAuthRole>()
                .Select(x => x.Role)
                .Where(x =>
                    x.UserAuthId == System.Convert.ToInt32(session.UserAuthId)
                    && x.Role != null
                    && x.Role != string.Empty
                )
        );
        List<string> Permissions = localDb.Column<string>(
            localDb
                .From<UserAuthRole>()
                .Select(x => x.Permission)
                .Where(x =>
                    x.UserAuthId == System.Convert.ToInt32(session.UserAuthId)
                    && x.Permission != null
                    && x.Permission != string.Empty
                )
        );
        localDb.Close();

        WoUserSession UserSession = new WoUserSession()
        {
            UserAuthName = session.UserAuthName,
            SessionId = session.Id,
            Instance = dto.Instance,
            Udn = dto.Udn,
            Year = dto.Year,
            Roles = Roles.Where(e => !e.IsNullOrEmpty()).ToList(),
            InstanceType = dto.InstanceType,
            Permissions = Permissions.Where(e => !e.IsNullOrEmpty()).ToList(),
        };

        try
        {
            var InstanciaUDNValueFind = HostContext.Cache.Get<WoUserSession>(
                InstanciaUDNKey.ToString()
            );

            //var InstanciaUDNValueFind = HostContext.Cache.Get<Tuple<string, string>>(
            //    InstanciaUDNKey.ToString()
            //);
            if (InstanciaUDNValueFind == null)
                HostContext.Cache.Add<WoUserSession>(InstanciaUDNKey.ToString(), UserSession);
            else
                HostContext.Cache.Set<WoUserSession>(InstanciaUDNKey.ToString(), UserSession);
        }
        catch (Exception ex)
        {
            HostContext.Cache.Add<WoUserSession>(InstanciaUDNKey.ToString(), UserSession);
        }

        string LogFile = "";
        string DataBaseName = "";
        tWoDataBaseProviders DbProvider = tWoDataBaseProviders.Sqlite;
        tWoIntanciaType IntanciaType = tWoIntanciaType.DEV;
        string DBConnString = GetDBConnString(
            null,
            req,
            container,
            out LogFile,
            out IntanciaType,
            out DataBaseName,
            out DbProvider
        );

        string DataBaseCreatedToken = "__DataBaseCreated__" + DBConnString;

        var DataBaseCreated = HostContext.Cache.Get<string>(DataBaseCreatedToken);

        IOrmLiteDialectProvider dialectProvider = null;
        if (DbProvider == tWoDataBaseProviders.Sqlite)
            dialectProvider = SqliteDialect.Provider;
        else if (DbProvider == tWoDataBaseProviders.SqlServer)
            dialectProvider = SqlServer2019Dialect.Provider;
        else if (DbProvider == tWoDataBaseProviders.MySql)
            dialectProvider = MySqlDialect.Provider;
        else if (DbProvider == tWoDataBaseProviders.Postgres)
            dialectProvider = PostgreSqlDialect.Provider;
        else
            throw new Exception("No se ha implementado el proveedor de base de datos");

        dbFactory = new OrmLiteConnectionFactory(DBConnString, dialectProvider);

        if (DataBaseCreated != null)
        {
            try
            {
                var db = dbFactory.Open();
                List<string> tableNames = db.GetTableNames();
                if (tableNames.Count == 0)
                    DataBaseCreated = null;
                db.Close();
            }
            catch (Exception ex)
            {
                DataBaseCreated = "Error";
            }
        }

        if ((DataBaseCreated == null) || (DataBaseCreated == "Error"))
        {
            //
            // Es una base de datos SQL Server conectarse a master, verificar si existe la base de datos y crearla
            //
            if (IntanciaType != tWoIntanciaType.DEV)
            {
                if (!WoDataBaseOperations.ExistsDataBase(Configuration, DataBaseName))
                    WoDataBaseOperations.CreateDataBase(Configuration, DataBaseName);
                Thread.Sleep(3000);
            }

            IDbConnection db = null;

            try
            {
                try
                {
                    db = dbFactory.Open();
                }
                catch
                {
                    Thread.Sleep(3000);
                    db = dbFactory.Open();
                }

                if (db.CreateTableIfNotExists<CrudEvent>())
                {
                    db.CreateIndex<CrudEvent>(e => e.Urn, "idx_crudevent_urn");
                    db.CreateIndex<CrudEvent>(e => e.EventDate, "idx_crudevent_eventdate");
                }

                if (IntanciaType != tWoIntanciaType.DEV)
                    OrmLiteConfig.SkipForeignKeys = true;

                CreateDB.Do(db, IntanciaType, DbProvider);

                if (IntanciaType != tWoIntanciaType.DEV)
                {
                    OrmLiteConfig.SkipForeignKeys = false;
                    CreateDB.DoForeignKey(db, IntanciaType, DbProvider);
                }

                string CompareSchema = WoSchema.CompareSchemaModel(
                    db,
                    WoLib.GetDBName(
                        UserSession.Instance,
                        UserSession.InstanceType,
                        UserSession.Year
                    ),
                    DbProvider
                );
                if (!CompareSchema.IsNullOrStringEmpty())
                {
                    File.WriteAllText(LogFile, CompareSchema);
                    HostContext.Cache.Remove(InstanciaUDNKey.ToString());

                    string errores = String.Join(
                        "\r\n",
                        CompareSchema.Split("\r\n").ToList().Take(15)
                    );

                    throw new Exception(
                        $"No se puede iniciar el servicio, error en base de datos, revise: {LogFile}\r\n\r\nPrimeras lineas del archivo:\r\n\r\n{errores}"
                    );
                }

                db.Close();
                HostContext.Cache.Set<string>(DataBaseCreatedToken, "Ok");
            }
            catch (Exception ex)
            {
                HostContext.Cache.Set<string>(DataBaseCreatedToken, "Error");
                if (db != null)
                    db.Close();
                if (ex.Message.Contains("iniciar el servicio"))
                    throw new Exception(ex.Message);
                else
                    throw new Exception(ex.Message + "\r\n" + db.GetLastSql());
            }
        }
        else
        {
            if (DataBaseCreated == "Error")
                throw new Exception(
                    $"La db {DBConnString} fue creada con errores no se puede ocupar"
                );
        }

        // Verifica que exista la UDN
        if (!dto.Udn.IsNullOrStringEmpty())
        {
            int NumeroDeUdn = 0;
            IDbConnection db = dbFactory.Open();
            try
            {
                NumeroDeUdn = db.SqlColumn<int>($"SELECT COUNT(*) FROM SysUdn").FirstOrDefault();
            }
            catch (Exception ex)
            {
                db.Close();
                HostContext.Cache.Remove(InstanciaUDNKey.ToString());
                throw new Exception(
                    $"No existe el modelo SysUdn envie en null o blanco en la Udn al usar IWoInstanciaUdnAsignar"
                );
            }

            if (NumeroDeUdn > 0)
            {
                // Si existen UDNs la valida si no lo deja pasar para que se configuren
                string Udn = db.SqlColumn<string>($"SELECT Id FROM SysUdn WHERE Id = '{dto.Udn}'")
                    .FirstOrDefault();

                if (Udn.IsNullOrStringEmpty())
                {
                    db.Close();
                    HostContext.Cache.Remove(InstanciaUDNKey.ToString());
                    throw new Exception($"No existe la UDN {dto.Udn}");
                }
            }
            db.Close();
        }

        return "Ok";
    }

    public string GetDBConnString(
        IWoInstanciaUdn dto,
        IRequest req,
        Container container,
        out string LogFile,
        out tWoIntanciaType IntanciaType,
        out string DataBaseName,
        out tWoDataBaseProviders DbProvider
    )
    {
        //var sessionKey = SessionFeature.GetSessionKey(req); //  (req.Cookies["ss-id"])
        //var session = HostContext.Cache.Get<AuthUserSession>(sessionKey);

        var jwtProvider = AuthenticateService.GetJwtAuthProvider();

        AuthUserSession session = new AuthUserSession();

        var token = req.GetBearerToken();

        if (token != null)
        {
            if (jwtProvider.IsJwtValid(token))
            {
                JsonObject payload = jwtProvider.GetValidJwtPayload(token);
                session.Id = payload["SessionId"];
                session.UserAuthName = payload["email"];
                session.UserAuthId = payload["UserAuthId"];
                var tok = token;
            }
            else
            {
                throw new Exception($"El token de autenticaci�n no es valido");
            }
        }
        else
        {
            throw new Exception($"No se puede recuperar el token de autenticaci�n");
        }

        //string sessionKey = session.Id;

        var InstanciaUDNKey = new Tuple<string, string>(session.UserAuthName, session.Id);
        var UserSession = HostContext.Cache.Get<WoUserSession>(InstanciaUDNKey.ToString());

        if (UserSession == null)
            throw new Exception("Configure Instancia y UDN");

        DataBaseName = WoLib.GetDBName(
            UserSession.Instance,
            UserSession.InstanceType,
            UserSession.Year
        );

        LogFile = $"{DataBaseName}.log";

        IntanciaType = UserSession.InstanceType;

        DataBaseName =
            $"DB_{UserSession.Instance}_{UserSession.InstanceType.ToString()}_{UserSession.Year}";

        if (UserSession.InstanceType == tWoIntanciaType.DEV)
        {
            if (!Directory.Exists($"{System.AppDomain.CurrentDomain.BaseDirectory}DBService"))
                Directory.CreateDirectory(
                    $"{System.AppDomain.CurrentDomain.BaseDirectory}DBService"
                );
            DbProvider = tWoDataBaseProviders.Sqlite;
            return $"data source = {System.AppDomain.CurrentDomain.BaseDirectory}DBService\\{DataBaseName}.sqlite;foreign keys = true;";
        }
        else
        {
            var SqlDatabaseType = Configuration.GetValue<string>(
                "WooWSettings:SqlDatabase",
                tWoDataBaseProviders.SqlServer.ToString()
            );

            if (
                (SqlDatabaseType != tWoDataBaseProviders.SqlServer.ToString())
                && (SqlDatabaseType != tWoDataBaseProviders.MySql.ToString())
                && (SqlDatabaseType != tWoDataBaseProviders.Postgres.ToString())
            )
                throw new Exception(
                    $"El tipo de base de datos {SqlDatabaseType} no es valido, valores admitidos en WooWSettings:SqlDatabase son: {tWoDataBaseProviders.SqlServer.ToString()}, {tWoDataBaseProviders.MySql.ToString()} y {tWoDataBaseProviders.Postgres.ToString()}"
                );

            var ConnString = Configuration.GetValue<string>("WooWSettings:ConnString", "");

            if (ConnString.IsNullOrStringEmpty())
                throw new Exception(
                    "No se puede recuperar la cadena de conexi�n de la base de datos"
                );

            var PasswordDataBase = Configuration.GetValue<string>(
                "WooWSettings:PasswordDataBase",
                ""
            );

            if (!PasswordDataBase.IsNullOrStringEmpty())
            {
                string locPassword = WoCrypto.ProtectDecrypt(PasswordDataBase);
                ConnString = ConnString.Replace("%Password%", locPassword);
            }

            if (SqlDatabaseType == tWoDataBaseProviders.SqlServer.ToString())
                DbProvider = tWoDataBaseProviders.SqlServer;
            else if (SqlDatabaseType == tWoDataBaseProviders.MySql.ToString())
                DbProvider = tWoDataBaseProviders.MySql;
            else if (SqlDatabaseType == tWoDataBaseProviders.Postgres.ToString())
            {
                DbProvider = tWoDataBaseProviders.Postgres;
                DataBaseName = DataBaseName.ToLower();
            }
            else
                throw new Exception(
                    $"El tipo de base de datos {SqlDatabaseType} no es valido, valores admitidos en WooWSettings:SqlDatabase son: {tWoDataBaseProviders.SqlServer.ToString()}, {tWoDataBaseProviders.MySql.ToString()} y {tWoDataBaseProviders.Postgres.ToString()}"
                );

            return string.Format(ConnString, DataBaseName);
        }
    }

    public tWoIntanciaType GetProviderName(IRequest req)
    {
        var jwtProvider = AuthenticateService.GetJwtAuthProvider();

        AuthUserSession session = new AuthUserSession();

        var token = req.GetBearerToken();

        if (token != null)
        {
            if (jwtProvider.IsJwtValid(token))
            {
                JsonObject payload = jwtProvider.GetValidJwtPayload(token);
                session.Id = payload["SessionId"];
                session.UserAuthName = payload["email"];
                session.UserAuthId = payload["UserAuthId"];
                var tok = token;
            }
            else
            {
                throw new Exception($"El token de autenticaci�n no es valido");
            }
        }
        else
        {
            throw new Exception($"No se puede recuperar el token de autenticaci�n");
        }

        var InstanciaUDNKey = new Tuple<string, string>(session.UserAuthName, session.Id);
        var UserSession = HostContext.Cache.Get<WoUserSession>(InstanciaUDNKey.ToString());

        if (UserSession == null)
            throw new Exception("Configure Instancia y UDN");

        return UserSession.InstanceType;
    }

    public interface IVXInstanciaUDN
    {
        public Dictionary<Tuple<string, string>, Tuple<string, string>> Dicc { get; }
    }

    public class VXInstanciaUDN : IVXInstanciaUDN
    {
        public Dictionary<Tuple<string, string>, Tuple<string, string>> Dicc { get; }

        public VXInstanciaUDN()
        {
            Dicc = new Dictionary<Tuple<string, string>, Tuple<string, string>>();
        }
    }
}

using ServiceStack.Data;
using ServiceStack.OrmLite;

[assembly: HostingStartup(typeof(WooW.ConfigureDb))]

namespace WooW
{
    public class ConfigureDb : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder) =>
            builder.ConfigureServices(
                (context, services) =>
                {
                    services.AddSingleton<IDbConnectionFactory>(
                        new OrmLiteConnectionFactory(
                            context.Configuration.GetConnectionString("DefaultConnection")
                                ?? $"{System.AppDomain.CurrentDomain.BaseDirectory}DBService\\WooW.DB.Config.sqlite",
                            SqliteDialect.Provider
                        )
                    );
                }
            );
    }
}

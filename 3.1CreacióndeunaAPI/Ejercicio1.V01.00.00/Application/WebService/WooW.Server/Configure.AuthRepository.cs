using Microsoft.AspNetCore.Identity;
using ServiceStack.Auth;
using ServiceStack.Configuration;
using ServiceStack.Data;
using ServiceStack.Web;

[assembly: HostingStartup(typeof(WooW.ConfigureAuthRepository))]

namespace WooW
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? DisplayName { get; set; }
        public string? ProfileUrl { get; set; }
    }

    // Custom User Table with extended Metadata properties
    public class AppUser : UserAuth
    {
        public string? ProfileUrl { get; set; }
        public string? LastLoginIp { get; set; }
        public DateTime? LastLoginDate { get; set; }
    }

    public class AppUserAuthEvents : AuthEvents
    {
        public override void OnAuthenticated(
            IRequest req,
            IAuthSession session,
            IServiceBase authService,
            IAuthTokens tokens,
            Dictionary<string, string> authInfo
        )
        {
            var authRepo = HostContext.AppHost.GetAuthRepository(req);
            using (authRepo as IDisposable)
            {
                var userAuth = (AppUser)authRepo.GetUserAuth(session.UserAuthId);
                userAuth.ProfileUrl = session.GetProfileUrl();
                userAuth.LastLoginIp = req.UserHostAddress;
                userAuth.LastLoginDate = DateTime.UtcNow;
                authRepo.SaveUserAuth(userAuth);
            }
        }
    }

    public class ConfigureAuthRepository : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder) =>
            builder
                //.ConfigureServices(services =>
                //{
                //    services.AddPlugin(new AuthFeature(IdentityAuth.For<ApplicationUser>(options =>
                //    {
                //        options.SessionFactory = () => new CustomUserSession();
                //        options.CredentialsAuth();
                //        //options.AdminUsersFeature();
                //    })));
                //})
                //.ConfigureServices(services => services.AddSingleton<IAuthRepository>(c =>
                //    new OrmLiteAuthRepository<AppUser, UserAuthDetails>(c.Resolve<IDbConnectionFactory>())
                //    {
                //        UseDistinctRoleTables = true
                //    }))

                .ConfigureServices(services =>
                    services.AddSingleton<IAuthRepository>(c => new OrmLiteAuthRepository<
                        AppUser,
                        UserAuthDetails
                    >(c.GetService<IDbConnectionFactory>())
                    {
                        UseDistinctRoleTables = true
                    })
                )
                .ConfigureAppHost(
                    appHost =>
                    {
                        var authRepo = appHost.Resolve<IAuthRepository>();
                        authRepo.InitSchema();
                        CreateUser(
                            authRepo,
                            "admin@email.com",
                            "Admin User",
                            "mypass",
                            roles: new[] { RoleNames.Admin },
                            permisions: new[] { WooW.Model.PermisionNames.UserAdd }
                        );
                    },
                    afterConfigure: appHost =>
                        appHost.AssertPlugin<AuthFeature>().AuthEvents.Add(new AppUserAuthEvents())
                );

        // Add initial Users to the configured Auth Repository
        public void CreateUser(
            IAuthRepository authRepo,
            string email,
            string name,
            string password,
            string[] roles,
            string[] permisions
        )
        {
            if (authRepo.GetUserAuthByUserName(email) == null)
            {
                var newAdmin = new AppUser { Email = email, DisplayName = name };
                var user = authRepo.CreateUserAuth(newAdmin, password);
                authRepo.AssignRoles(user, roles, permisions);
            }
        }
    }
}

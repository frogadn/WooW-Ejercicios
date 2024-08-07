//using Quartz;
using ServiceStack.Auth;
using WooW.Core;

namespace WooW
{
    /*
    public class MyJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {

            return Task.CompletedTask;


            var client = new JsonServiceClient(@"https://localhost:5001");

            AuthenticateResponse authResponse = client.Post<AuthenticateResponse>(new Authenticate
            {
                provider = CredentialsAuthProvider.Name, //= credentials
                UserName = "employee@email.com",
                Password = "p",
                RememberMe = true,
            });

            var authResponse2 = client.Post(new InstanciaUdnAsignar
            {
                Instancia = "4",
                Udn = "INDU"
            });

            var authResponse3 = client.Get(new Authenticate
            {
                provider = "logout"
            });



            for (int i = 0; i < 100000; i++)
            {
                var j = i;
            }
            return context.AsTaskResult();
        }
    }
    */
}

// ------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta. WooW.SB ttModeloRequestServiceInterface
//     Versión del runtime: 1.0.0.0
//  
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
// ------------------------------------------------------------------------------//
using WooW.Core.Server;
using WooW.Core;
using WooW.DTO;
using WooW.Model;
using ServiceStack;
using ServiceStack.Web;
using Microsoft.Extensions.Configuration;

namespace WooW.ServiceInterface  
{
    public class WoSendMailMimeServiceInterface : Service
    {
        private readonly IConfiguration _configuration;

        public WoSendMailMimeServiceInterface(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public WoResponseGeneric Post(WoSendMailMime GetRequest)
        {
            return WoSendMailMime.Post(new WoTargetConnection(Request, Db), GetRequest, _configuration);
        }



    }
}

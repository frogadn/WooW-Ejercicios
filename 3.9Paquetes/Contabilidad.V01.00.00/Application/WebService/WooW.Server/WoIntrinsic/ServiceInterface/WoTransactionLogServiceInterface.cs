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

namespace WooW.ServiceInterface  
{
    public class WoTransactionLogServiceInterface : Service
    {
        public IList<WoTransactionLogRes> Get(WoTransactionLog GetRequest)
        {
            return WoTransactionLog.Get(new WoTargetConnection(Request, Db), GetRequest);
        }




    }
}

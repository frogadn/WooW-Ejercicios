 
  
// ------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta. WooW.SB ttModeloRequestServicioCliente.tt
//     Versión del runtime: 1.0.0.0
//  
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
// ------------------------------------------------------------------------------//
using WooW.Core; 
using WooW.DTO;
using ServiceStack;

namespace WooW.Model
{
    public partial class WoSendMail
    {

        public static WoResponseGeneric Post(
            JsonApiClient Client, WoSendMail Request)
        {
            return Client.Post<WoResponseGeneric>(Request);
        }

        public static async Task<WoResponseGeneric> PostAsync(
            JsonApiClient Client, WoSendMail Request)
        {
            return await Client.PostAsync<WoResponseGeneric>(Request);
        }



    }
}

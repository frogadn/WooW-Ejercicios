// ------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta. WooW.SB ttModeloServicioRequest
//     Versión del runtime: 1.0.0.0
//  
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
// ------------------------------------------------------------------------------//
using WooW.Core.Server;
using WooW.Core;
using WooW.DTO;
using ServiceStack;
using ServiceStack.OrmLite;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace WooW.Model
{
    public partial class WoSendMailMime
    {

        public static WoResponseGeneric Post(WoTargetConnection woTarget, WoSendMailMime Request, IConfiguration _configuration)
        {
            WoSendMailMimeScript Script = new WoSendMailMimeScript();

            return Script.WoSendMailMimePost<WoSendMailMime, WoResponseGeneric>(
                woTarget, Request, _configuration);
        }



    }
}

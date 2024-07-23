using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Configuration;
using MimeKit;
using ServiceStack;
using ServiceStack.OrmLite;
using WooW.Core;
using WooW.Core.Server;
using WooW.DTO;
using WooW.Model;

namespace WooW.Model
{
    //
    // Parámetro HelperMailMimeMessage request
    // Parámetro SysResponseGeneric response
    //
    // No modifique las estructura de la llamada del método
    // Pude agregar a la clase propiedades, métodos o funciones
    //
    // Generado por ttModeloScript
    //
    public class WoSendMailMimeScript
    {
        // Método para el request HelperMailMimeMessage
        public RES WoSendMailMimePost<REQ, RES>(
            WoTargetConnection woTarget,
            REQ reqWoSendMailMime,
            IConfiguration configuration
        )
            where REQ : WoSendMailMime, new()
            where RES : WoResponseGeneric, new()
        {
            var MailServidor = configuration.GetValue<string>("WooWSettings:MailServidor");

            var MailPuerto = configuration.GetValue<int>("WooWSettings:MailPuerto");

            var MailUsuario = configuration.GetValue<string>("WooWSettings:MailUsuario");

            var MailPassword = configuration.GetValue<string>("WooWSettings:MailPassword");

            var MailSsl = configuration.GetValue<string>("WooWSettings:MailSsl");

            MemoryStream msMail = new MemoryStream(reqWoSendMailMime.MimeMessage);

            var email = MimeMessage.Load(msMail, false);

            string response = WoLib.SendMail(
                email,
                MailServidor,
                MailPuerto,
                MailUsuario,
                MailPassword,
                MailSsl
            );

            RES WoResponseGeneric = new RES();

            if (response == "OK")
            {
                WoResponseGeneric.NumeroErrores = 0;
                WoResponseGeneric.Respuesta = true;
            }
            else
            {
                WoResponseGeneric.NumeroErrores = 1;
                WoResponseGeneric.Respuesta = false;
                WoResponseGeneric.Error = response;
            }

            return WoResponseGeneric;
        }
    }
}

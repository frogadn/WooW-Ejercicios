using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;
using ServiceStack;
using ServiceStack.OrmLite;
using WooW.Core;
using WooW.Core.Common;
using WooW.Core.Server;
using WooW.DTO;
using WooW.Model;

namespace WooW.Model
{
    //
    // Parámetro HelperMail request
    // Parámetro WoResponseGeneric response
    //
    // No modifique las estructura de la llamada del método
    // Pude agregar a la clase propiedades, métodos o funciones
    //
    // Generado por ttModeloScript
    //
    public class WoSendMailScript
    {
        // Método para el request HelperMail
        public RES WoSendMailPost<REQ, RES>(
            WoTargetConnection woTarget,
            REQ WoSend,
            IConfiguration configuration
        )
            where REQ : WoSendMail, new()
            where RES : WoResponseGeneric, new()
        {
            var MailServidor = configuration.GetValue<string>("WooWSettings:MailServidor");

            var MailPuerto = configuration.GetValue<int>("WooWSettings:MailPuerto");

            var MailUsuario = configuration.GetValue<string>("WooWSettings:MailUsuario");

            var MailPassword = configuration.GetValue<string>("WooWSettings:MailPassword");

            var MailSsl = configuration.GetValue<string>("WooWSettings:MailSsl");

            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(WoSend.De));

            string[] Destinatarios = WoSend.Para.Split(";");

            foreach (string destinatario in Destinatarios)
                if (!Destinatarios.IsNullOrStringEmpty())
                    email.To.Add(MailboxAddress.Parse(destinatario));

            email.Subject = WoSend.Asunto;

            if (WoSend.EsHtml)
            {
                email.Body = new TextPart(TextFormat.Html) { Text = WoSend.Mensaje }; // "<h1>Example HTML Message Body</h1>" };
            }
            else
            {
                email.Body = new TextPart(TextFormat.Plain) { Text = WoSend.Mensaje };
            }

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

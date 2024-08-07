using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    // Parámetro TransactionLog request
    // Parámetro TransactionLogResponse response
    //
    // No modifique las estructura de la llamada del método
    // Pude agregar a la clase propiedades, métodos o funciones
    //
    // Generado por ttModeloScript
    //
    public class WoTransactionLogScript
    {
        // Método para el request TransactionLog
        public IList<RES> WoTransactionLogGet<REQ, RES>(
            WoTargetConnection woTarget,
            REQ reqWoTransactionLog
        )
            where REQ : WoTransactionLog, new()
            where RES : WoTransactionLogRes, new()
        {
            string resultsString = string.Empty;

            List<CrudEvent> results = woTarget.Db.SqlList<CrudEvent>(
                "SELECT * FROM CrudEvent WHERE Model = @Model and ModelId = @ModelId ORDER BY Id",
                new { Model = reqWoTransactionLog.Model, ModelId = reqWoTransactionLog.ModelId }
            );

            var Response = new List<RES>();

            foreach (var result in results)
            {
                var log = Core.Common.WoTransactionLog.FromJson(result.RequestBody);

                //log.RequestBody;
                //log.ModelBody;

                // Recuperar el Tipo por usando el nombre por reflexion
                // Rutina generica para poderlo manipular json
                // Contruir a mano html y css o render fragment en blazor
                resultsString += log.ModelBody;
                Response.Add(
                    new RES()
                    {
                        RequestBody = log.RequestBody,
                        EventType = result.EventType,
                        EventDate = result.EventDate.ToUniversalTime().ToString(),
                        ModelBody = log.ModelBody,
                        UserAuthName = result.UserAuthName,
                        Urn = result.Urn
                    }
                );
            }

            var Response2 = new WoResponseHtml { Html = resultsString };

            return Response;
        }
    }
}

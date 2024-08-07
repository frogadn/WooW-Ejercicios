using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;
using ServiceStack;
using ServiceStack.OrmLite;
using WooW.Core;
using WooW.Core.Server;
using WooW.DTO;
using WooW.Model;

namespace WooW.Model
{
    //
    // Par�metro GetMenusReq request
    // Par�metro GetMenusRes response
    //
    // No modifique las estructura de la llamada del m�todo
    // Pude agregar a la clase propiedades, m�todos o funciones
    //
    // Generado por ttModeloScript
    //
    public class WoMenusReqScript
    {
        // M�todo para el request GetMenusReq
        public IList<RES> WoMenusReqGet<REQ, RES>(WoTargetConnection woTarget, REQ reqWoMenusReq)
            where REQ : WoMenusReq, new()
            where RES : WoMenusRes, new()
        {
            string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            string[] Files = Directory.GetFiles(string.Format(@"{0}\Menus", assemblyPath), "*.*");
            var Response = new List<RES>();

            foreach (string file in Files)
            {
                try
                {
                    string Json = File.ReadAllText(file);
                    dynamic jsonResponse = JsonConvert.DeserializeObject(Json);
                    if (jsonResponse.Roles == null)
                    {
                        continue;
                    }
                    var Roles = jsonResponse.Roles;
                    foreach (var Rol in Roles)
                    {
                        if (
                            woTarget.Roles.Where(e => e == Rol.Id.ToString()).FirstOrDefault()
                            != null
                        )
                            Response.Add(new RES() { Rol = Rol.Id, Menu = Json });
                    }
                }
                catch { }
            }

            return Response;
        }
    }
}

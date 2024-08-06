using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack;
using ServiceStack.OrmLite;
using WooW.Core;
using WooW.Core.Server;
using WooW.DTO;
using WooW.Model;

namespace WooW.Model
{
    //
    // Par�metro GetRolePermissionReq request
    // Par�metro GetRolePermissionRes response
    //
    // No modifique las estructura de la llamada del m�todo
    // Pude agregar a la clase propiedades, m�todos o funciones
    //
    // Generado por ttModeloScript
    //
    public class WoRolePermissionReqScript
    {
        // M�todo para el request GetRolePermissionReq
        public RES WoRolePermissionReqGet<REQ, RES>(
            WoTargetConnection woTarget,
            REQ reqWoRolePermissionReq
        )
            where REQ : WoRolePermissionReq, new()
            where RES : WoRolePermissionRes, new()
        {
            var Response = new RES();

            Response.RoleCol = new List<string>(woTarget.Roles);
            Response.PermissionCol = new List<string>(woTarget.Permissions);

            return Response;
        }
    }
}

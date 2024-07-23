using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
    // Par�metro ReportGetReq request
    // Par�metro ReportGetRes response
    //
    // No modifique las estructura de la llamada del m�todo
    // Pude agregar a la clase propiedades, m�todos o funciones
    //
    // Generado por ttModeloScript
    //
    public class WoReportReqScript
    {
        // M�todo para el request ReportGetReq
        public RES WoReportReqGet<REQ, RES>(WoTargetConnection woTarget, REQ reqSysReportReq)
            where REQ : WoReportReq, new()
            where RES : WoReportRes, new()
        {
            string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            string sfile = string.Format(
                "{0}\\Reportes\\{1}.xml",
                assemblyPath,
                reqSysReportReq.Reporte
            );

            if (!File.Exists(sfile))
                throw new Exception(string.Format("Archivo {0} no existe", sfile));

            RES v = new RES();

            v.Reporte = File.ReadAllText(sfile);

            return v;
        }
    }
}

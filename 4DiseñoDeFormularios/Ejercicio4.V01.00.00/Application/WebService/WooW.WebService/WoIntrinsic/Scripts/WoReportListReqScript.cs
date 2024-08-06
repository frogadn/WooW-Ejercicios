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
    // Par�metro ReportListReq request
    // Par�metro ReportListRes response
    //
    // No modifique las estructura de la llamada del m�todo
    // Pude agregar a la clase propiedades, m�todos o funciones
    //
    // Generado por ttModeloScript
    //
    public class WoReportListReqScript
    {
        // M�todo para el request ReportListReq
        public RES WoReportListReqGet<REQ, RES>(WoTargetConnection woTarget, REQ reqWoReportListReq)
            where REQ : WoReportListReq, new()
            where RES : WoReportListRes, new()
        {
            string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            string[] Files = Directory.GetFiles(
                string.Format("{0}\\Reportes", assemblyPath),
                string.Format("{0}.xml", reqWoReportListReq.Reporte)
            );

            RES v = new RES();

            v.ReporteCol = new List<string>();

            foreach (string file in Files)
                v.ReporteCol.Add(Path.GetFileNameWithoutExtension(file));

            Files = Directory.GetFiles(
                string.Format("{0}\\Reportes", assemblyPath),
                string.Format("{0}.*.xml", reqWoReportListReq.Reporte)
            );

            foreach (string file in Files)
                v.ReporteCol.Add(Path.GetFileNameWithoutExtension(file));

            return v;
        }
    }
}

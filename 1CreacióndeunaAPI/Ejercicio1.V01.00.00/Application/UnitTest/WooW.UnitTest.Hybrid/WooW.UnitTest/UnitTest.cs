using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using ServiceStack;
using ServiceStack.Text;
using WooW.Core;
using WooW.Core.Server;
//using ServiceStack.Auth;
using WooW.DTO;
using WooW.Model;

namespace WooW
{
    [Serializable]
    public class Prueba2UnitTest : IWoUnitHybridTest
    {
        #region Parametros

        public string User { get; set; }
        public string Password { get; set; }
        public string Instance { get; set; }
        public string Udn { get; set; }
        public int Year { get; set; }
        public decimal[] ParamsDecimal { get; set; }
        public string[] ParamsString { get; set; }
        public int ExecuteNumber { get; set; }
        public IWoUnitTestHelper Uth { get; set; }
        public string LocalDB { get; set; }

        #endregion Propiedades

        public bool Run(WoTargetConnection woTarget)
        {
            var oProMarca = ProMarca.Get(woTarget.GetRemoteClient(), "PEP");

            //            var oProMarcaNuevo = ProMarca.Post(woTarget, oProMarca.ConvertTo<ProMarcaNuevo>());

            //            var oProMarcaLocal = ProMarca.Get(woTarget, "PEP");

            //            Uth.Log("Marca Local " + oProMarca.Descripcion);



            return true;
        }
    }
}

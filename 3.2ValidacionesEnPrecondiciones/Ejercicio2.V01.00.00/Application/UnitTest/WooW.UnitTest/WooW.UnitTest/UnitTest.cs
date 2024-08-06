using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack;
using ServiceStack.Text;
using WooW.Core;
//using ServiceStack.Auth;
//using System.Threading;
using WooW.DTO;
using WooW.Model;

//using Newtonsoft.Json;

namespace WooW
{
    [Serializable]
    public class PruebaUnitTest : IWoUnitTest
    {
        #region Parametros

        public string User { get; set; }
        public string DataBase { get; set; }
        public tWoIntanciaType InstanceType { get; set; }
        public string Instance { get; set; }
        public string Udn { get; set; }
        public int Year { get; set; }
        public decimal[] ParamsDecimal { get; set; }
        public string[] ParamsString { get; set; }
        public int ExecuteNumber { get; set; }
        public IWoUnitTestHelper Uth { get; set; }

        #endregion Propiedades

        public bool Run(ServiceStack.JsonApiClient woTarget)
        {
            var oProMarca = ProMarca.Post(
                woTarget,
                new ProMarcaNuevo()
                {
                    Id = "A",
                    Descripcion = "AB",
                    DescripcionCorta = "C",
                    WoState = eProMarca_WoState.Activo
                }
            );

            Uth.Log(oProMarca.Dump());

            return true;
        }
    }
}

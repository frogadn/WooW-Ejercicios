using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
//using ServiceStack;
using ServiceStack.Text;
//using ServiceStack.Auth;
//using System.Threading;
using WooW.DTO;
using WooW.Model;
using WooW.Core;
//using Newtonsoft.Json;

namespace WooW
{
	[Serializable]
	public class RegistroBancosUnitTest : IWoUnitTest
	{
		#region Parametros

		public string User
		{
			get; set;
		}
		public string DataBase
		{
			get; set;
		}
		public tWoIntanciaType InstanceType
		{
			get; set;
		}
		public string Instance
		{
			get; set;
		}
		public string Udn
		{
			get; set;
		}
		public int Year
		{
			get; set;
		}
		public decimal[] ParamsDecimal
		{
			get; set;
		}
		public string[] ParamsString
		{
			get; set;
		}
		public int ExecuteNumber
		{
			get; set;
		}
		public IWoUnitTestHelper Uth
		{
			get; set;
		}

		#endregion Propiedades

		public bool Run(ServiceStack.JsonApiClient woTarget)
		{

			var oBanco = Banco.Post(woTarget, new BancoNuevo()
			{
				Id = "BNX",
				Nombre = "Banamex",
				Rfc = "BNM840515VB1",
				WoState = eBanco_WoState.Activo
			});
			Uth.Log(oBanco.Dump());

			oBanco = Banco.Post(woTarget, new BancoNuevo()
			{
				Id = "ACT",
				Nombre = "Actinver",
				Rfc = "KAHO641101B39",
				WoState = eBanco_WoState.Activo
			});
			Uth.Log(oBanco.Dump());

			oBanco = Banco.Post(woTarget, new BancoNuevo()
			{
				Id = "AZT",
				Nombre = "Azteca",
				Rfc = "AZTO641101B39",
				WoState = eBanco_WoState.Activo
			});
			Uth.Log(oBanco.Dump());

			Uth.LogSuccess("Prueba: Registro de Bancos Finalizada");

			return true;
		}
	}
}

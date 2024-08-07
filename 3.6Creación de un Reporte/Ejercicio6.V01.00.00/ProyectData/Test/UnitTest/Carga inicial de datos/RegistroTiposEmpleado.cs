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
	public class RegistroTiposEmpleadoUnitTest : IWoUnitTest
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

			// Ponga aqui su codigo

			var oTipoDeEmpleado = TipoDeEmpleado.Post(woTarget, new TipoDeEmpleadoNuevo()
			{
				Id = "1000",
				Nombre = "Tiempo Completo",
				Descripcion = "Empleado que trabaja durante la jornada laboral completa estándar",
				TieneBeneficios = true,
				WoState = eTipoDeEmpleado_WoState.Activo
			});
			Uth.Log(oTipoDeEmpleado.Dump());

			oTipoDeEmpleado = TipoDeEmpleado.Post(woTarget, new TipoDeEmpleadoNuevo()
			{
				Id = "2000",
				Nombre = "Medio Tiempo",
				Descripcion = "Empleado que trabaja durante la mitad de la jornada laboral estándar",
				TieneBeneficios = false,
				WoState = eTipoDeEmpleado_WoState.Activo
			});
			Uth.Log(oTipoDeEmpleado.Dump());

			oTipoDeEmpleado = TipoDeEmpleado.Post(woTarget, new TipoDeEmpleadoNuevo()
			{
				Id = "3000",
				Nombre = "Contratista",
				Descripcion = "Empleado contratado para un proyecto específico con una duración determinada",
				TieneBeneficios = false,
				WoState = eTipoDeEmpleado_WoState.Activo
			});
			Uth.Log(oTipoDeEmpleado.Dump());

			oTipoDeEmpleado = TipoDeEmpleado.Post(woTarget, new TipoDeEmpleadoNuevo()
			{
				Id = "4000",
				Nombre = "Temporal",
				Descripcion = "Empleado contratado por un período corto para cubrir necesidades temporales",
				TieneBeneficios = false,
				WoState = eTipoDeEmpleado_WoState.Activo
			});
			Uth.Log(oTipoDeEmpleado.Dump());

			oTipoDeEmpleado = TipoDeEmpleado.Post(woTarget, new TipoDeEmpleadoNuevo()
			{
				Id = "5000",
				Nombre = "Practicante",
				Descripcion = "Estudiante o recién graduado que trabaja para ganar experiencia práctica",
				TieneBeneficios = false,
				WoState = eTipoDeEmpleado_WoState.Activo
			});
			Uth.Log(oTipoDeEmpleado.Dump());

			Uth.LogSuccess("Prueba: Registro de Tipos de Empleado Finalizada");

			return true;
		}
	}
}

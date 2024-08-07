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
	public class RegistroEmpleadosUnitTest : IWoUnitTest
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

			var oEmpleado = Empleado.Post(woTarget, new EmpleadoNuevo()
			{
				Id = "1000",
				Nombre = "Juan Antonio Ayola Cortes",
				FechaDeNacimiento = new DateTime(2000, 9, 17),
				EstadoCivil = eEmpleado_EstadoCivil.Soltero,
				Correo = "jayola@frog.com.mx",
				Telefono = "7711825937",
				Salario = 20000.0m,
				TipoDeEmpleadoId = "1000",
				WoState = eEmpleado_WoState.Activo
			});
			Uth.Log(oEmpleado.Dump());

			oEmpleado = Empleado.Post(woTarget, new EmpleadoNuevo()
			{
				Id = "2000",
				Nombre = "María Guadalupe Sánchez Pérez",
				FechaDeNacimiento = new DateTime(1985, 5, 20),
				EstadoCivil = eEmpleado_EstadoCivil.Casado,
				Correo = "maria.sanchez@empresa.com",
				Telefono = "5512345678",
				Salario = 18000.0m,
				TipoDeEmpleadoId = "2000",
				WoState = eEmpleado_WoState.Activo
			});
			Uth.Log(oEmpleado.Dump());

			oEmpleado = Empleado.Post(woTarget, new EmpleadoNuevo()
			{
				Id = "3000",
				Nombre = "Luis Fernando Pérez Gómez",
				FechaDeNacimiento = new DateTime(1990, 11, 30),
				EstadoCivil = eEmpleado_EstadoCivil.UnionLibre,
				Correo = "luis.perez@empresa.com",
				Telefono = "5587654321",
				Salario = 22000.0m,
				TipoDeEmpleadoId = "3000",
				WoState = eEmpleado_WoState.Activo
			});
			Uth.Log(oEmpleado.Dump());

			oEmpleado = Empleado.Post(woTarget, new EmpleadoNuevo()
			{
				Id = "4000",
				Nombre = "Ana Carolina López Martínez",
				FechaDeNacimiento = new DateTime(1995, 3, 14),
				EstadoCivil = eEmpleado_EstadoCivil.Viudo,
				Correo = "ana.lopez@empresa.com",
				Telefono = "5523456789",
				Salario = 15000.0m,
				TipoDeEmpleadoId = "4000",
				WoState = eEmpleado_WoState.Activo
			});
			Uth.Log(oEmpleado.Dump());

			oEmpleado = Empleado.Post(woTarget, new EmpleadoNuevo()
			{
				Id = "5000",
				Nombre = "Roberto Carlos Hernández Ramírez",
				FechaDeNacimiento = new DateTime(1998, 8, 22),
				EstadoCivil = eEmpleado_EstadoCivil.Divorciado,
				Correo = "roberto.hernandez@empresa.com",
				Telefono = "5534567890",
				Salario = 25000.0m,
				TipoDeEmpleadoId = "5000",
				WoState = eEmpleado_WoState.Activo
			});
			Uth.Log(oEmpleado.Dump());
			Uth.LogSuccess("Prueba: Registro de Empleados Finalizada");

			return true;
		}
	}
}

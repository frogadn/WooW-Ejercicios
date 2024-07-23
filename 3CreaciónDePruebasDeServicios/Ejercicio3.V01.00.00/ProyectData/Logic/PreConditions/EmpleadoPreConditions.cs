using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using ServiceStack;
using ServiceStack.OrmLite;
using WooW.Core.Server;
using WooW.Core;
using WooW.Core.Common;
using WooW.DTO;

namespace WooW.Model
{
	//  
	// Parametro dtoEmpleado(+ transición) DTO modelo como base para insertar o actualizar
	// Parametro curEmpleado modelo que actualmente esta registrado
	//
	// No modifique las estructura de la llamada del metodo
	// Pude agregar a la clase propiedades, metodos o funciones
	//
	// Generado por ttModeloScriptPre
	//

	public class EmpleadoPreConditions
	{
		public EmpleadoPreConditions(WoTargetConnection woTarget)
		{

		}

		#region Validar
		private void Validar<MOD>(WoTargetConnection woTarget, MOD oEmpleado)
			where MOD : Empleado
		{
			// Validar que el empleado sea mayor de 18 años
			var today = DateTime.Today;
			if(DateTime.Compare(oEmpleado.FechaDeNacimiento.AddYears(18), today) > 0)
			{
				throw new Exception("El empleado debe ser mayor de 18 años.");
			}

			// Validación de email
			string emailRegex = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
			if(!System.Text.RegularExpressions.Regex.IsMatch(oEmpleado.Correo, emailRegex))
			{
				throw new Exception("El email proporcionado no es válido.");
			}

			// Validar que el número de teléfono sea válido
			var phoneRegex = @"^\d{10}$"; if(!System.Text.RegularExpressions.Regex.IsMatch(oEmpleado.Telefono, phoneRegex))
			{
				throw new Exception("El número de teléfono no es válido.");
			}

			// Validar que el salario no sea negativo
			if(oEmpleado.Salario < 0)
			{
				throw new Exception("El salario no puede ser un número negativo.");
			}

			// Validar que el salario no sea menor al salario mínimo
			const decimal salarioMinimo = 7500m;
			if(oEmpleado.Salario < salarioMinimo)
			{
				throw new Exception($"El salario no puede ser menor al salario mínimo de {salarioMinimo}.");
			}

			// Valida que el correo no este ocupado
			long Valor = woTarget.Db.Count<Empleado>(x => x.Correo == oEmpleado.Correo);
			if(Valor > 0)
			{
				throw new Exception(string.Format("El correo {0} ya esta ocupado", oEmpleado.Correo));
			}
		}
		#endregion Validar

		// Método para el modelo Empleado de pre condición para la transición Nuevo de 0 a 100
		#region EmpleadoNuevo
		public void EmpleadoNuevo<DTO, MOD>(WoTargetConnection woTarget, DTO dtoEmpleadoNuevo, MOD emptyEmpleado)
			where DTO : EmpleadoNuevo
			where MOD : Empleado, new()
		{
			WoModelToModel.Copy(ref emptyEmpleado, dtoEmpleadoNuevo);
			Validar(woTarget, emptyEmpleado);
			WoModelToModel.Copy(ref dtoEmpleadoNuevo, emptyEmpleado);
		}
		#endregion EmpleadoNuevo

		// Método para el modelo Empleado de pre condición para la transición Suspender de 100 a 500
		#region EmpleadoSuspender
		public void EmpleadoSuspender<DTO, MOD>(WoTargetConnection woTarget, DTO dtoEmpleadoSuspender, MOD curEmpleado, woModifyVerb verb)
			where DTO : EmpleadoSuspender
			where MOD : Empleado, new()
		{
		}
		#endregion EmpleadoSuspender

		// Método para el modelo Empleado de pre condición para la transición Modificar de 100 a 100
		#region EmpleadoModificar
		public void EmpleadoModificar<DTO, MOD>(WoTargetConnection woTarget, DTO dtoEmpleadoModificar, MOD curEmpleado, woModifyVerb verb)
			where DTO : EmpleadoModificar
			where MOD : Empleado, new()
		{
			MOD emptyEmpleado = new MOD();
			WoModelToModel.Copy(ref emptyEmpleado, curEmpleado);
			WoModelToModel.Copy(ref emptyEmpleado, dtoEmpleadoModificar);
			Validar(woTarget, emptyEmpleado);
			WoModelToModel.Copy(ref dtoEmpleadoModificar, emptyEmpleado);
		}
		#endregion EmpleadoModificar

		// Método para el modelo Empleado de pre condición para la transición Activar de 500 a 100
		#region EmpleadoActivar
		public void EmpleadoActivar<DTO, MOD>(WoTargetConnection woTarget, DTO dtoEmpleadoActivar, MOD curEmpleado, woModifyVerb verb)
			where DTO : EmpleadoActivar
			where MOD : Empleado, new()
		{
		}
		#endregion EmpleadoActivar

		// Método para el modelo Empleado de pre condición para la transición DarDeBaja de 500 a 600
		#region EmpleadoDarDeBaja
		public void EmpleadoDarDeBaja<DTO, MOD>(WoTargetConnection woTarget, DTO dtoEmpleadoDarDeBaja, MOD curEmpleado, woModifyVerb verb)
			where DTO : EmpleadoDarDeBaja
			where MOD : Empleado, new()
		{
		}
		#endregion EmpleadoDarDeBaja

		#region EmpleadoBorrar
		public void EmpleadoBorrar<DTO, MOD>(WoTargetConnection woTarget, DTO dtoEmpleadoBorrar, MOD curEmpleado)
			where DTO : EmpleadoBorrar
			where MOD : Empleado, new()
		{

		}
		#endregion EmpleadoBorrar

	}
}

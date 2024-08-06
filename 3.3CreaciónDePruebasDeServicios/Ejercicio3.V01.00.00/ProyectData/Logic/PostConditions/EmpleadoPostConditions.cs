using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using ServiceStack;
using ServiceStack.OrmLite;
using WooW.Core.Server;
using WooW.Core;
using WooW.DTO;

namespace WooW.Model
{
	//
	// Parametro modEmpleado modelo a insert o actualizar
	// Parametro curEmpleado modelo que actualmente esta registrado
	//
	// No modifique las estructura de la llamada del metodo
	// Pude agregar a la clase propiedades, metodos o funciones
	//
	// Generado por ttModeloScriptPost
	//

	public class EmpleadoPostConditions
	{
		public EmpleadoPostConditions(WoTargetConnection woTarget)
		{

		}



		// Método para el modelo Empleado de post condición para la transición Nuevo de 0 a 100
		#region EmpleadoNuevo
		public void EmpleadoNuevo<MOD>(WoTargetConnection woTarget, MOD modEmpleado)
			where MOD : Empleado
		{

		}
		#endregion EmpleadoNuevo




		// Método para el modelo Empleado de post condición para la transición Suspender de 100 a 500
		#region EmpleadoSuspender
		public void EmpleadoSuspender<MOD>(WoTargetConnection woTarget, MOD modEmpleado, MOD curEmpleado)
			where MOD : Empleado
		{

		}
		#endregion EmpleadoSuspender


		// Método para el modelo Empleado de post condición para la transición Modificar de 100 a 100
		#region EmpleadoModificar
		public void EmpleadoModificar<MOD>(WoTargetConnection woTarget, MOD modEmpleado, MOD curEmpleado)
			where MOD : Empleado
		{

		}
		#endregion EmpleadoModificar


		// Método para el modelo Empleado de post condición para la transición Activar de 500 a 100
		#region EmpleadoActivar
		public void EmpleadoActivar<MOD>(WoTargetConnection woTarget, MOD modEmpleado, MOD curEmpleado)
			where MOD : Empleado
		{

		}
		#endregion EmpleadoActivar


		// Método para el modelo Empleado de post condición para la transición DarDeBaja de 500 a 600
		#region EmpleadoDarDeBaja
		public void EmpleadoDarDeBaja<MOD>(WoTargetConnection woTarget, MOD modEmpleado, MOD curEmpleado)
			where MOD : Empleado
		{

		}
		#endregion EmpleadoDarDeBaja
	}
}

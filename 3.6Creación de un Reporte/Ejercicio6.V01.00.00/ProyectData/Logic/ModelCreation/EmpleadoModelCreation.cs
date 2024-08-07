using System;
using System.Data;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using ServiceStack;
using ServiceStack.OrmLite;
using WooW.Core.Server;
using WooW.Core;
using WooW.Core.Common;
using WooW.DTO;
using WooW.Core.Common;

namespace WooW.Model
{
	//
	//
	// No modifique las estructura de la llamada del metodo
	// Pude agregar a la clase propiedades, metodos o funciones
	//
	// Generado por ttModeloScriptCreacion
	//

	public class EmpleadoCreate
	{
		//
		// Este metodo se llama para crear o actualizar la tabla
		// Si no existe el metodo solamente llama CreateTableIfNotExists
		//
		public static void Do(IDbConnection Db, tWoIntanciaType IntanciaType, tWoDataBaseProviders DbProvider)
		{
			if(Db.CreateTableIfNotExists<Empleado>())
			{

			}
		}
	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooW.WebDriver.Components.Inputs;

namespace WooW.ModelTest.Empleado.Components
{
    public class SuspendDate
    {
        #region Atributos

        /// <summary>
        /// Instancia del texto de SuspendDate
        /// </summary>
        private WoDateEdit _dteSuspendDate;

        /// <summary>
        /// Valor del input
        /// </summary>
        public DateTime Value
        {
            get
            {
                try
                {
                    return Get();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            set
            {
                try
                {
                    Set(value);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        #endregion Atributos

        #region Constructor

        /// <summary>
        /// Constructor principal de la clase
        /// </summary>
        /// <exception cref="Exception"></exception>
        public SuspendDate()
        {
            try
            {
                _dteSuspendDate = new WoDateEdit("dteSuspendDate");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion Constructor


        #region Métodos

        /// <summary>
        /// Obtiene el valor del input
        /// </summary>
        /// <returns>Valor del input</returns>
        /// <exception cref="Exception"></exception>
        private DateTime Get()
        {
            try
            {
                // Recuperamos el valor desde el input
                string value = _dteSuspendDate.GetValue();

                // Dividimos el valor en partes
                string[] valueCol = value.Split('/');
                
                // Creamos una fecha con los valores obtenidos
                DateTime date = new DateTime(int.Parse(valueCol[2]), int.Parse(valueCol[1]), int.Parse(valueCol[0]));

                // Retornamos la fecha
                return date;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Recupera el valor en string con el formato que se pasa por parámetro
        /// </summary>
        /// <param name="formato"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private string Get(string formato = "dd/MM/yyyy")
        {
            try
            {
                // Recuperamos el valor desde el input
                string value = _dteSuspendDate.GetValue();

                // Dividimos el valor en partes
                string[] valueCol = value.Split('/');

                // Creamos una fecha con los valores obtenidos
                DateTime date = new DateTime(int.Parse(valueCol[2]), int.Parse(valueCol[1]), int.Parse(valueCol[0]));

                // Retornamos la fecha con el formato indicado
                return date.ToString(formato);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Establece el valor del input
        /// </summary>
        /// <param name="value">Valor a establecer</param>
        /// <exception cref="Exception"></exception>
        private void Set(DateTime value)
        {
            try
            {
                // Enviamos el valor al input
                _dteSuspendDate.SetValue(value);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion Métodos
    }
}


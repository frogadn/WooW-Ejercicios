
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooW.WebDriver.Components.Inputs;

namespace WooW.ModelTest.Empleado.Components
{
    public class EstadoCivil
    {
        #region Atributos

        /// <summary>
        /// Instancia de EstadoCivil
        /// </summary>
        private WoComboEdit _cmbEstadoCivil;

        /// <summary>
        /// Valor del input
        /// </summary>
        public eEmpleado_EstadoCivil Value
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
        public EstadoCivil()
        {
            try
            {
                _cmbEstadoCivil = new WoComboEdit("cmbEstadoCivil", "cei");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion Constructor


        #region Métodos

        /// <summary>
        /// Recuperación del valor de la instancia
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public eEmpleado_EstadoCivil Get()
        {
            try
            {
                // Recuperamos el valor del input
                string value = _cmbEstadoCivil.GetValue();

                // Convertimos el valor a enumeración y lo retornamos
                return (eEmpleado_EstadoCivil)Enum.Parse(typeof(eEmpleado_EstadoCivil), value, true);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Envía el valor que se recibe por parámetro al input
        /// </summary>
        /// <param name="newValue"></param>
        /// <exception cref="Exception"></exception>
        public void Set(eEmpleado_EstadoCivil newValue)
        {
            try
            {
                // Convertimos el valor a string
                string strNewValue = newValue.ToString();

                // Enviamos el valor al input
                _cmbEstadoCivil.SetValue(strNewValue);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion Métodos
    }
}


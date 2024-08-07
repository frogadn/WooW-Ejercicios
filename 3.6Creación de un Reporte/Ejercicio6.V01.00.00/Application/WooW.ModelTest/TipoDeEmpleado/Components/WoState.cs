
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooW.WebDriver.Components.Inputs;

namespace WooW.ModelTest.TipoDeEmpleado.Components
{
    public class WoState
    {
        #region Atributos

        /// <summary>
        /// Instancia de WoState
        /// </summary>
        private WoComboEdit _cmbWoState;

        /// <summary>
        /// Valor del input
        /// </summary>
        public eTipoDeEmpleado_WoState Value
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
        public WoState()
        {
            try
            {
                _cmbWoState = new WoComboEdit("cmbWoState", "cei");
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
        public eTipoDeEmpleado_WoState Get()
        {
            try
            {
                // Recuperamos el valor del input
                string value = _cmbWoState.GetValue();

                // Convertimos el valor a enumeración y lo retornamos
                return (eTipoDeEmpleado_WoState)Enum.Parse(typeof(eTipoDeEmpleado_WoState), value, true);
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
        public void Set(eTipoDeEmpleado_WoState newValue)
        {
            try
            {
                // Convertimos el valor a string
                string strNewValue = newValue.ToString();

                // Enviamos el valor al input
                _cmbWoState.SetValue(strNewValue);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion Métodos
    }
}


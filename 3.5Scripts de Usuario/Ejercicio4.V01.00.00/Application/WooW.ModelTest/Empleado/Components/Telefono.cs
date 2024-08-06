
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooW.WebDriver.Components.Inputs;

namespace WooW.ModelTest.Empleado.Components
{
    public class Telefono
    {
        #region Atributos

        /// <summary>
        /// Instancia de Telefono
        /// </summary>
        private WoMaskedEdit _mkdTelefono;

        /// <summary>
        /// Valor del input
        /// </summary>
        public string Value
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
        public Telefono()
        {

            try
            {
                _mkdTelefono = new WoMaskedEdit("mkdTelefono");
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
        public string Get()
        {
            try
            {
                // Recuperamos lo que tiene el input
                string value = _mkdTelefono.GetValue();

                // Lo convertimos a string y lo retornamos
                return string.Parse(value);
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
        public void Set(string newValue)
        {
            try
            {
                // Convertimos el valor a string
                string strNewValue = newValue.ToString();

                // Enviamos el valor al input
                _mkdTelefono.SetValue(strNewValue);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion Métodos
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooW.WebDriver.Components.Inputs;

namespace WooW.ModelTest.Banco.Components
{
    public class Rfc
    {
        #region Atributos

        /// <summary>
        /// Instancia del texto de Rfc
        /// </summary>
        private WoTextEdit _txtRfc;

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
        public Rfc()
        {

            try
            {
                _txtRfc = new WoTextEdit("txtRfc");
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
                return _txtRfc.GetValue();
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
                _txtRfc.SetValue(newValue);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion Métodos
    }
}


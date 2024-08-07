
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooW.WebDriver.Components.Inputs;

namespace WooW.ModelTest.TipoDeEmpleado.Components
{
    public class ModifiedBy
    {
        #region Atributos

        /// <summary>
        /// Instancia del texto de ModifiedBy
        /// </summary>
        private WoTextEdit _txtModifiedBy;

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
        public ModifiedBy()
        {

            try
            {
                _txtModifiedBy = new WoTextEdit("txtModifiedBy");
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
                return _txtModifiedBy.GetValue();
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
                _txtModifiedBy.SetValue(newValue);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion Métodos
    }
}


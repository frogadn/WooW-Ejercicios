
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooW.WebDriver.Components.Containers;

namespace WooW.ModelTest.Banco.Components
{
    public class formControlform
    {
        #region Atributos

        /// <summary>
        /// Instancia de la tab
        /// </summary>
        private WoTab _formControlform;

        #endregion Atributos

        #region Constructor

        /// <summary>
        /// Constructor principal de la clase
        /// </summary>
        /// <exception cref="Exception"></exception>
        public formControlform()
        {
            try
            {
                _formControlform = new WoTab("formControlform");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion Constructor


        #region Métodos

        /// <summary>
        /// Selecciona la tab
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void SelectTab()
        {
            try
            {
                _formControlform.Click();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion Métodos
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooW.WebDriver.Components.Inputs;

namespace WooW.ModelTest.TipoDeEmpleado.Components
{
    public class TieneBeneficios
    {
        #region Atributos

        /// <summary>
        /// Instancia de TieneBeneficios
        /// </summary>
        private WoCheckEdit _chkTieneBeneficios;

        /// <summary>
        /// Valor del input
        /// </summary>
        public bool Value
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
        public TieneBeneficios()
        {
            try
            {
                _chkTieneBeneficios = new WoCheckEdit("chkTieneBeneficios");
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
        public bool Get()
        {
            try
            {
                return _chkTieneBeneficios.GetValue();
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
        public void Set(bool newValue)
        {
            try
            {
                _chkTieneBeneficios.SetValue(newValue);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion Métodos
    }
}


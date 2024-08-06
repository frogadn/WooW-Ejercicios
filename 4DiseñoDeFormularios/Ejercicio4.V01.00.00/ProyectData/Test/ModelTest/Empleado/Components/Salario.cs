
public class Salario
{
    #region Atributos

    /// <summary>
    /// Instancia de Salario
    /// </summary>
    private WoMaskedEdit _mkdSalario;

    /// <summary>
    /// Valor del input
    /// </summary>
    public Decimal Value
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
    public Salario()
    {

        try
        {
            _mkdSalario = new WoMaskedEdit("mkdSalario");
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
    public Decimal Get()
    {
        try
        {
            // Recuperamos lo que tiene el input
            string value = _mkdSalario.GetValue();

            // Lo convertimos a Decimal y lo retornamos
            return Decimal.Parse(value);
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
    public void Set(Decimal newValue)
    {
        try
        {
            // Convertimos el valor a string
            string strNewValue = newValue.ToString();

            // Enviamos el valor al input
            _mkdSalario.SetValue(strNewValue);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    #endregion Métodos
}


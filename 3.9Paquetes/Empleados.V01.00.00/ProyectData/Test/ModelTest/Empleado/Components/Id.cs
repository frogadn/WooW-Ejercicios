
public class Id
{
    #region Atributos

    /// <summary>
    /// Instancia del texto de Id
    /// </summary>
    private WoTextEdit _txtId;

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
    public Id()
    {

        try
        {
            _txtId = new WoTextEdit("txtId");
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
            return _txtId.GetValue();
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
            _txtId.SetValue(newValue);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    #endregion Métodos
}


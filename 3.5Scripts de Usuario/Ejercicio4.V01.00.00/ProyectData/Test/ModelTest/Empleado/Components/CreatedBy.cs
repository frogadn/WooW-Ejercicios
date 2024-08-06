
public class CreatedBy
{
    #region Atributos

    /// <summary>
    /// Instancia del texto de CreatedBy
    /// </summary>
    private WoTextEdit _txtCreatedBy;

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
    public CreatedBy()
    {

        try
        {
            _txtCreatedBy = new WoTextEdit("txtCreatedBy");
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
            return _txtCreatedBy.GetValue();
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
            _txtCreatedBy.SetValue(newValue);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    #endregion Métodos
}

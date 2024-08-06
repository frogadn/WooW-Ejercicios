
public class DeletedBy
{
    #region Atributos

    /// <summary>
    /// Instancia del texto de DeletedBy
    /// </summary>
    private WoTextEdit _txtDeletedBy;

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
    public DeletedBy()
    {

        try
        {
            _txtDeletedBy = new WoTextEdit("txtDeletedBy");
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
            return _txtDeletedBy.GetValue();
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
            _txtDeletedBy.SetValue(newValue);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    #endregion Métodos
}

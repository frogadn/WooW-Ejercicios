
public class TipoDeEmpleadoForm
{
    #region Atributos

    /// <summary>
    /// Instancia de la barra de herramientas
    /// </summary>
    public WoToolBar ToolBar;

        
    /// <summary>
    /// Instancia del input de la propiedad formFormModel
    /// </summary>
    public formFormModel formFormModel;

        
    /// <summary>
    /// Instancia del input de la propiedad formControlform
    /// </summary>
    public formControlform formControlform;

    
    #endregion Atributos

    #region Constructor

    /// <summary>
    /// Constructor principal de la clase
    /// </summary>
    /// <exception cref="Exception"></exception>
    public TipoDeEmpleadoForm()
    {
        try
        {
            // Incializamos la barra de herramientas
            ToolBar = new WoToolBar();

        
            // Inicialización del componente formFormModel
            formFormModel = new formFormModel();

        
            // Inicialización del componente formControlform
            formControlform = new formControlform();

        
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    #endregion Constructor

}


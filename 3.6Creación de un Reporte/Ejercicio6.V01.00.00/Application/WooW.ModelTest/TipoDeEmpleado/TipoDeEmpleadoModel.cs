
public class TipoDeEmpleadoModel
{
    #region Atributos

    
    /// <summary>
    /// Instancia del input de la propiedad Id
    /// </summary>
    public Id Id;

    
    /// <summary>
    /// Instancia del input de la propiedad Nombre
    /// </summary>
    public Nombre Nombre;

    
    /// <summary>
    /// Instancia del input de la propiedad Descripcion
    /// </summary>
    public Descripcion Descripcion;

    
    /// <summary>
    /// Instancia del input de la propiedad TieneBeneficios
    /// </summary>
    public TieneBeneficios TieneBeneficios;

    
    /// <summary>
    /// Instancia del input de la propiedad WoState
    /// </summary>
    public WoState WoState;

    
    /// <summary>
    /// Instancia del input de la propiedad CreatedDate
    /// </summary>
    public CreatedDate CreatedDate;

    
    /// <summary>
    /// Instancia del input de la propiedad CreatedBy
    /// </summary>
    public CreatedBy CreatedBy;

    
    /// <summary>
    /// Instancia del input de la propiedad ModifiedDate
    /// </summary>
    public ModifiedDate ModifiedDate;

    
    /// <summary>
    /// Instancia del input de la propiedad ModifiedBy
    /// </summary>
    public ModifiedBy ModifiedBy;

    
    /// <summary>
    /// Instancia del input de la propiedad SuspendDate
    /// </summary>
    public SuspendDate SuspendDate;

    
    /// <summary>
    /// Instancia del input de la propiedad SuspendBy
    /// </summary>
    public SuspendBy SuspendBy;

    
    /// <summary>
    /// Instancia del input de la propiedad SuspendInfo
    /// </summary>
    public SuspendInfo SuspendInfo;

    
    /// <summary>
    /// Instancia del input de la propiedad DeletedDate
    /// </summary>
    public DeletedDate DeletedDate;

    
    /// <summary>
    /// Instancia del input de la propiedad DeletedBy
    /// </summary>
    public DeletedBy DeletedBy;

    
    /// <summary>
    /// Instancia del input de la propiedad DeleteInfo
    /// </summary>
    public DeleteInfo DeleteInfo;

    
    /// <summary>
    /// Instancia del input de la propiedad Alertas
    /// </summary>
    public Alertas Alertas;

    
    /// <summary>
    /// Instancia del input de la propiedad Controles
    /// </summary>
    public Controles Controles;

    
    #endregion Atributos

    #region Constructor

    /// <summary>
    /// Constructor principal de la clase
    /// </summary>
    /// <exception cref="Exception"></exception>
    public TipoDeEmpleadoModel()
    {
        try
        {

        
            // Inicialización del componente Id
            Id = new Id();

        
            // Inicialización del componente Nombre
            Nombre = new Nombre();

        
            // Inicialización del componente Descripcion
            Descripcion = new Descripcion();

        
            // Inicialización del componente TieneBeneficios
            TieneBeneficios = new TieneBeneficios();

        
            // Inicialización del componente WoState
            WoState = new WoState();

        
            // Inicialización del componente CreatedDate
            CreatedDate = new CreatedDate();

        
            // Inicialización del componente CreatedBy
            CreatedBy = new CreatedBy();

        
            // Inicialización del componente ModifiedDate
            ModifiedDate = new ModifiedDate();

        
            // Inicialización del componente ModifiedBy
            ModifiedBy = new ModifiedBy();

        
            // Inicialización del componente SuspendDate
            SuspendDate = new SuspendDate();

        
            // Inicialización del componente SuspendBy
            SuspendBy = new SuspendBy();

        
            // Inicialización del componente SuspendInfo
            SuspendInfo = new SuspendInfo();

        
            // Inicialización del componente DeletedDate
            DeletedDate = new DeletedDate();

        
            // Inicialización del componente DeletedBy
            DeletedBy = new DeletedBy();

        
            // Inicialización del componente DeleteInfo
            DeleteInfo = new DeleteInfo();

        
            // Inicialización del componente Alertas
            Alertas = new Alertas();

        
            // Inicialización del componente Controles
            Controles = new Controles();

        
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    #endregion Constructor

}


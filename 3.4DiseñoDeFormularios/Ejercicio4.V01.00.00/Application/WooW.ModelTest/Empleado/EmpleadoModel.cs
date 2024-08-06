
public class EmpleadoModel
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
    /// Instancia del input de la propiedad FechaDeNacimiento
    /// </summary>
    public FechaDeNacimiento FechaDeNacimiento;

    
    /// <summary>
    /// Instancia del input de la propiedad EstadoCivil
    /// </summary>
    public EstadoCivil EstadoCivil;

    
    /// <summary>
    /// Instancia del input de la propiedad Salario
    /// </summary>
    public Salario Salario;

    
    /// <summary>
    /// Instancia del input de la propiedad Correo
    /// </summary>
    public Correo Correo;

    
    /// <summary>
    /// Instancia del input de la propiedad Telefono
    /// </summary>
    public Telefono Telefono;

    
    /// <summary>
    /// Instancia del input de la propiedad TipoDeEmpleadoId
    /// </summary>
    public TipoDeEmpleadoId TipoDeEmpleadoId;

    
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
    public EmpleadoModel()
    {
        try
        {

        
            // Inicialización del componente Id
            Id = new Id();

        
            // Inicialización del componente Nombre
            Nombre = new Nombre();

        
            // Inicialización del componente FechaDeNacimiento
            FechaDeNacimiento = new FechaDeNacimiento();

        
            // Inicialización del componente EstadoCivil
            EstadoCivil = new EstadoCivil();

        
            // Inicialización del componente Salario
            Salario = new Salario();

        
            // Inicialización del componente Correo
            Correo = new Correo();

        
            // Inicialización del componente Telefono
            Telefono = new Telefono();

        
            // Inicialización del componente TipoDeEmpleadoId
            TipoDeEmpleadoId = new TipoDeEmpleadoId();

        
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


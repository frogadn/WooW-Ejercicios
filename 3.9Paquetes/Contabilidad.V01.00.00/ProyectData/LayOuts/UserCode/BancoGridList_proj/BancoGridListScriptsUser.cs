
public partial class BancoGridListScriptsUser
{
    /// <summary>
    /// Inyección del runtime de blazor para la ejecución de código js por parte del usuario.
    /// </summary>
    public IJSRuntime JS { get; set; }
    /// <summary>
    /// Permite al usuario detonar un evento de actualización de la vista.
    /// </summary>
    public Action? StateHasChangeEvt { get; set; }
    /// <summary>
    /// Indica cual es la transición en la que se encuentra el formulario actualmente.
    /// </summary>
    public string Transicion { get; set; } = "Navegacion";

    /// <summary>
    /// Asigna las instancias inyectadas desde el despachador de dependencias de blazor.
    /// </summary>
    public BancoGridListScriptsUser(BancoGridListControls BancoGridListControles, IJSRuntime js)
    {
        this.BancoGridListControles = BancoGridListControles;
        this.JS = js;
    }

#region Atributos (modelos y controles)
    /// <summary>
    /// Cliente que se puede usar en el codigo para llamar a los servicios.
    /// </summary>
    public JsonApiClient woTarget { get; set; }

    /// <summary>
    /// Instancia de la clase que contiene los valores bindeados a los controles de la vista.
    /// </summary>
    public BancoGridList BancoGridList = new BancoGridList();
    /// <summary>
    /// Inyeccion del la clase que contiene las vistas de los controles de la vista.
    /// </summary>
    public BancoGridListControls BancoGridListControles { get; set; }

    /// <summary>
    /// Lista de los elementos seleccionados en la lista
    /// </summary>
    public List<Banco> BancoSeleccionados = new List<Banco>();
#endregion Atributos (modelos y controles)
#region Formulario
    /// <summary>
    /// Metodo que se ejecuta cuando se inicia el formulario.
    /// </summary>
    /// <returns></returns>
    public void FormularioIniciado()
    {
        // Codigo que se ejecutara al iniciar el formulario.
        FormSettings();
    }

    /// <summary>
    /// Metodo con la configuración del formulario, se llama desde el metodo FormularioIniciado.
    /// </summary>
    /// <returns></returns>
    private void FormSettings()
    {
    }

#endregion Formulario
#region Banco
    // Este código fue generado por el fichero WoTextEditScriptUser.cs.
    // WoWSB por el generador a día 25-10-2023
    public void OnPageIndexChanged()
    {
    }

    public void OnPageSizeChanged()
    {
    }

    public void OnFilterChanged()
    {
    }

    public void OnFilterReset()
    {
    }

    public void OnSelectedRowChanged(Banco SelectedRow)
    {
        Banco = SelectedRow;
    }

    public void SelectedBancoItemsChanged(IEnumerable<Banco> banco)
    {
        BancoSeleccionados = banco.ToList();
    }

    public void BtnNew_OnClick()
    {
        ///
        ;
    }

    public void BtnEdit_OnClick()
    {
        string route = $@"/SYS/CatalogType/Banco";
        JS.InvokeAsync<object>("NavigateTo", [route]);
    }

    public void BtnCopyToNew_OnClick()
    {
        ///
        ;
    }
#endregion Banco
}


///------------------------------------------------------------------------------------------------------------------
/// Código autogenerado por la template WoTemplateGenericClass en el path WooW.SB\BlazorGenerator\BlazorTemplates\CommonTemplates\UserCode\WoTemplateScriptsUserBlazor.tt
/// Genera código consistente con la version de la prueba de concepto a dia 05-10-2023 En Blazor Wasm y Server
/// Este código es auto generado y su modificación puede causar que el código no se comporte como deveria ademas de
/// que se perderan los cambios realizados en el código al momento de la generación.
///------------------------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Reflection;
using ServerUnitModel_proj.ControlModels;
using System.Threading.Tasks;
using FluentValidation;

using WooW.Model;

using ServiceStack;

using WooW.DTO;

using WooW.Blazor;
using WooW.Blazor.Resources; 

using Microsoft.JSInterop;


namespace ServerUnitModel_proj.UserCode
{
    public partial class ServerUnitModelGridListScriptsUser
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
    public ServerUnitModelGridListScriptsUser(ServerUnitModelGridListControls EmpleadoGridListControles, IJSRuntime js)
    {
        this.EmpleadoGridListControles = EmpleadoGridListControles;
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
    public Empleado Empleado = new Empleado();
    /// <summary>
    /// Inyeccion del la clase que contiene las vistas de los controles de la vista.
    /// </summary>
    public ServerUnitModelGridListControls EmpleadoGridListControles { get; set; }

    /// <summary>
    /// Lista de los elementos seleccionados en la lista
    /// </summary>
    public List<Empleado> EmpleadoSeleccionados = new List<Empleado>();
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
#region Empleado
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

    public void OnSelectedRowChanged(Empleado SelectedRow)
    {
        Empleado = SelectedRow;
    }

    public void SelectedEmpleadoItemsChanged(IEnumerable<Empleado> empleado)
    {
        EmpleadoSeleccionados = empleado.ToList();
    }

    public void BtnNew_OnClick()
    {
        ///
        ;
    }

    public void BtnEdit_OnClick()
    {
        string route = $@"/SYS/Catalog/Empleado";
        JS.InvokeAsync<object>("NavigateTo", [route]);
    }

    public void BtnCopyToNew_OnClick()
    {
        ///
        ;
    }
#endregion Empleado
}
}


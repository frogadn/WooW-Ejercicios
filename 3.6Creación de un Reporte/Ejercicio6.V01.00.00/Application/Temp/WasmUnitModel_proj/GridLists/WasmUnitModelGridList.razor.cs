///------------------------------------------------------------------------------------------------------------------
/// Código autogenerado por la template WoTemplateGenericClass en el path WooW.SB\BlazorGenerator\BlazorTemplates\CommonTemplates\Slaves\WoTemplateSlavePartialBlazor.tt
/// Genera código consistente con la version de la prueba de concepto a dia 05-10-2023 En Blazor Wasm y Server
/// Este código es auto generado y su modificación puede causar que el código no se comporte como deveria ademas de
/// que se perderan los cambios realizados en el código al momento de la generación.
///------------------------------------------------------------------------------------------------------------------
using WasmUnitModel_proj.ControlModels;
using WasmUnitModel_proj.FluentValidators;
using WasmUnitModel_proj.UserCode;
using WasmUnitModel_proj.Auth;
using DevExpress.Data;
using FluentValidation.Results;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Components;

//WooW
using WooW.Core;
using WooW.DTO;
using WooW.Model;

using static ServiceStack.Diagnostics.Events;
using DevExpress.XtraReports.UI;
using System.Data;
using Newtonsoft.Json;
using WooW.Blazor.Resources;
using WooW.Blazor.Services;
using WooW.Blazor;
 
namespace WasmUnitModel_proj.GridLists
{
	
    public partial class WasmUnitModelGridList
    {

        #region Atributos

        // Código generado por el método BuildHeaderClass en la clase WoLayoutPartialGenerator.cs 

        /// <summary>
        /// Inyección de la clase con las vistas para manipular los controles.
        /// </summary>
        [Inject]
        public WasmUnitModelGridListControls _modelControls { get; set; }


        /// <summary>
        /// Instancia con los métodos de los eventos de los controles.
        /// </summary>
        [Inject]
        public WasmUnitModelGridListScriptsUser _scriptsUser { get; set; }


        /// <summary>
        /// Variable con el valor del parámetro del identificador que se puede recibir como parámetro.
        /// Indica en que registro se posicionara la navegación.
        /// </summary>
        private string _idParameter = string.Empty;

     #region Instancias de los scripts de otros formularios



     #endregion Instancias de los scripts de otros formularios

        #endregion Atributos



        #region Métodos adicionales

        /// <summary>
        /// Método que permite actualizar el formulario.
        /// Solo realiza un re dibujado de la vista.
        /// </summary>
        private void UpdateEntireForm() => StateHasChanged();

        /// <summary>
        /// Indicador del primer rende rizado de la vista.
        /// Permite controlar lo que se ejecuta en métodos sin esta bandera.
        /// </summary>
        private bool _firstRender = true;

        /// <summary>
        /// Verifica que el formulario se haya iniciado y
        /// si es el caso, ejecuta el método de inicio.
        /// </summary>
        private void CheckForm()
        {
            _scriptsUser.FormularioIniciado();
        }

        #endregion Métodos adicionales

        #region métodos del ciclo de vida

        /// <summary>
        /// Se detona madamas iniciar la pantalla, re instancia el cliente a partir de los datos en el
        /// local storage y obtiene parámetros en el caso que de la url venga con ellos.
        /// </summary>
        /// <returns></returns>
        protected override async Task OnInitializedAsync()
        {
            try
            {
                Client = await GetClientAsync();
                if (_firstRender)
                {
                    if (Client != null)
                    {
                        _scriptsUser.woTarget = Client;

                        ///Servicios de controles específicos                     
                        try
                        {
                        /// Inicializa los servicios de los componentes

                TipoDeEmpleadoListGrid_GetColumns();

                        }
                        catch (Exception ex)
                        {
                            throw new Exception($@"Error al inicializar los servicios de los componentes (lookups, report...) {ex.Message}");
                        }
                    }
        
                    /// Actualizamos el rende rizado de la vista con los datos de la consulta de navegación, ya sea
                    /// move to o last.
                    StateHasChanged();
        
                    /// Actualizamos el valor de la bandera para evitar que el código dentro del if se ejecute en cada state has change
                    _firstRender = false;
                }
            }
            catch (Exception ex)
            {
                /// En caso de error, se detona la alerta con la configuración de error.
                _modelControls.Alertas.AgregarAlerta($@"Ocurrió un error en el método OnInitialize del formulario: {ex.Message}", eTipoDeAlerta.Error, true);
            }
        }


        /// <summary>
        /// Evento del ciclo de vida de blazor, se ejecuta después de rende rizar el formulario.
        /// Recibe un parámetro que indica si es la primera vez que se rende riza el formulario, 
        /// permite detonar código solo la primera vez que rende riza.
        /// </summary>
        /// <param name="firstRender"></param>
        /// <returns></returns>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {

                if (_TipoDeEmpleadoListGridListGrid != null && Client.BearerToken != null && _TipoDeEmpleadoListGridListGrid.WoTarget == null)
                {
                    _TipoDeEmpleadoListGridListGrid.WoTarget = Client;
                    StateHasChanged();
                }

            if (firstRender) 
            {
                try
                {

                }
                catch (Exception ex)
                {
                    _modelControls.Alertas.AgregarAlerta($@"Ocurrió un error en el método OnAfterRenderAsync del formulario: {ex.Message}");
                }
                
            }
        }
 
        #endregion métodos del ciclo de vida

        #region Alertas
        // Este código fue generado por el fichero WoAlertListPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorAlerts\WoAlertList\WoAlertListPartial.cs
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente de alertas.
        /// </summary>
        private WoFormAlert? _alerts;


        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusAlerts()
        {
            if (_alerts != null)
            {
                _modelControls.Alertas.AddAlertEvt += _alerts.AddAlert;
                _modelControls.Alertas.RemoveAlertEvt += _alerts.RemoveAlert;
                _modelControls.Alertas.CleanAlertsEvt += _alerts.CleanAll;
            }
        }

        #endregion Alertas
        #region TipoDeEmpleadoListGrid

        // Este código fue generado por el fichero WoListGridPartial.cs.
        #region Toolbar

        /// <summary>
        /// Referencia del grid
        /// </summary>
        private WoODataGrid<TipoDeEmpleado, App> _TipoDeEmpleadoListGridListGrid;

        /// <summary>
        /// Valor seleccionado.
        /// </summary>
        private TipoDeEmpleado? _TipoDeEmpleadoListGridselectedvalue;

        /// <summary>
        /// Ruta del formulario.
        /// </summary>
        private string _TipoDeEmpleadoListGridFormRoute => "SYS/CatalogType/TipoDeEmpleado";

        private async Task TipoDeEmpleadoListGrid_RedirectTo()
        {
            string value = _TipoDeEmpleadoListGridselectedvalue.Id.ToString();
            if (!string.IsNullOrEmpty(value))
            {
                string route = (_TipoDeEmpleadoListGridFormRoute == string.Empty) ? "/" : $@"{_TipoDeEmpleadoListGridFormRoute}?Id={value}";
                //await JSRuntime.InvokeAsync<object>("OpenInNewtab", new object[2] { route, "_blank" });
                NavigationManager?.NavigateTo(route);
            }
            else
            {
                string route = (_TipoDeEmpleadoListGridFormRoute == string.Empty) ? "/" : $@"{_TipoDeEmpleadoListGridFormRoute}";
                //await JSRuntime.InvokeAsync<object>("OpenInNewtab", new object[2] { route, "_blank" });
                NavigationManager?.NavigateTo(route);
            }
        }
        #endregion Toolbar


        #region Columnas

        /// <summary>
        /// Lista de las columnas que se ban a mostrar por default.
        /// </summary>
        private List<WoGridColumn> _TipoDeEmpleadoListGridColumns = new List<WoGridColumn>();

        /// <summary>
        /// Recupera por reflexión las columnas que se van a mostrar en la lista.
        /// </summary>
        private void TipoDeEmpleadoListGrid_GetColumns()
        {
            try
            {
                _TipoDeEmpleadoListGridColumns.Clear();


                _TipoDeEmpleadoListGridColumns.Add(
                    new WoGridColumn() 
                    {
                        PropertyName = "Id",
                        Label = "Id",
                        PropertyType = typeof(string),
                        ListVisible = true,
                        Width = "100px",
                        IsRef = false,
                        FormRoute = ""
                    });

                _TipoDeEmpleadoListGridColumns.Add(
                    new WoGridColumn() 
                    {
                        PropertyName = "Nombre",
                        Label = "Nombre",
                        PropertyType = typeof(string),
                        ListVisible = true,
                        Width = "100px",
                        IsRef = false,
                        FormRoute = ""
                    });

                _TipoDeEmpleadoListGridColumns.Add(
                    new WoGridColumn() 
                    {
                        PropertyName = "Descripcion",
                        Label = "Descripcion",
                        PropertyType = typeof(string),
                        ListVisible = true,
                        Width = "100px",
                        IsRef = false,
                        FormRoute = ""
                    });

                _TipoDeEmpleadoListGridColumns.Add(
                    new WoGridColumn() 
                    {
                        PropertyName = "TieneBeneficios",
                        Label = "TieneBeneficios",
                        PropertyType = typeof(bool),
                        ListVisible = true,
                        Width = "100px",
                        IsRef = false,
                        FormRoute = ""
                    });

                _TipoDeEmpleadoListGridColumns.Add(
                    new WoGridColumn() 
                    {
                        PropertyName = "WoState",
                        Label = "State",
                        PropertyType = typeof(eTipoDeEmpleado_WoState),
                        ListVisible = false,
                        Width = "100px",
                        IsRef = false,
                        FormRoute = ""
                    });

                _TipoDeEmpleadoListGridColumns.Add(
                    new WoGridColumn() 
                    {
                        PropertyName = "RowVersion",
                        Label = "VersionEnDb",
                        PropertyType = typeof(ulong),
                        ListVisible = false,
                        Width = "100px",
                        IsRef = false,
                        FormRoute = ""
                    });

                _TipoDeEmpleadoListGridColumns.Add(
                    new WoGridColumn() 
                    {
                        PropertyName = "SuspendInfo",
                        Label = "CausaDeSuspension",
                        PropertyType = typeof(string),
                        ListVisible = false,
                        Width = "100px",
                        IsRef = false,
                        FormRoute = ""
                    });

                _TipoDeEmpleadoListGridColumns.Add(
                    new WoGridColumn() 
                    {
                        PropertyName = "SuspendBy",
                        Label = "SuspendidoPor",
                        PropertyType = typeof(string),
                        ListVisible = false,
                        Width = "100px",
                        IsRef = false,
                        FormRoute = ""
                    });

                _TipoDeEmpleadoListGridColumns.Add(
                    new WoGridColumn() 
                    {
                        PropertyName = "SuspendDate",
                        Label = "FechaDeSuspension",
                        PropertyType = typeof(DateTime),
                        ListVisible = false,
                        Width = "100px",
                        IsRef = false,
                        FormRoute = ""
                    });

                _TipoDeEmpleadoListGridColumns.Add(
                    new WoGridColumn() 
                    {
                        PropertyName = "CreatedDate",
                        Label = "FechaDeCreacion",
                        PropertyType = typeof(DateTime),
                        ListVisible = false,
                        Width = "100px",
                        IsRef = false,
                        FormRoute = ""
                    });

                _TipoDeEmpleadoListGridColumns.Add(
                    new WoGridColumn() 
                    {
                        PropertyName = "CreatedBy",
                        Label = "CreadoPor",
                        PropertyType = typeof(string),
                        ListVisible = false,
                        Width = "100px",
                        IsRef = false,
                        FormRoute = ""
                    });

                _TipoDeEmpleadoListGridColumns.Add(
                    new WoGridColumn() 
                    {
                        PropertyName = "ModifiedDate",
                        Label = "FechaDeModificacion",
                        PropertyType = typeof(DateTime),
                        ListVisible = false,
                        Width = "100px",
                        IsRef = false,
                        FormRoute = ""
                    });

                _TipoDeEmpleadoListGridColumns.Add(
                    new WoGridColumn() 
                    {
                        PropertyName = "ModifiedBy",
                        Label = "ModificadoPor",
                        PropertyType = typeof(string),
                        ListVisible = false,
                        Width = "100px",
                        IsRef = false,
                        FormRoute = ""
                    });

                _TipoDeEmpleadoListGridColumns.Add(
                    new WoGridColumn() 
                    {
                        PropertyName = "DeleteInfo",
                        Label = "CausaDeBorrado",
                        PropertyType = typeof(string),
                        ListVisible = false,
                        Width = "100px",
                        IsRef = false,
                        FormRoute = ""
                    });

                _TipoDeEmpleadoListGridColumns.Add(
                    new WoGridColumn() 
                    {
                        PropertyName = "DeletedDate",
                        Label = "FechaDeBorrado",
                        PropertyType = typeof(DateTime),
                        ListVisible = false,
                        Width = "100px",
                        IsRef = false,
                        FormRoute = ""
                    });

                _TipoDeEmpleadoListGridColumns.Add(
                    new WoGridColumn() 
                    {
                        PropertyName = "DeletedBy",
                        Label = "BorradoPor",
                        PropertyType = typeof(string),
                        ListVisible = false,
                        Width = "100px",
                        IsRef = false,
                        FormRoute = ""
                    });


            }
            catch (Exception ex)
            {
                _modelControls.Alertas.AgregarAlerta(ex.Message, eTipoDeAlerta.Error, true);
            }
        }

        #endregion Columnas


        #region Selección de la data

        /// <summary>
        /// Modelo seleccionado en la lista.
        /// </summary>
        /// <param name="selectedModel"></param>
        /// <returns></returns>
        private void TipoDeEmpleadoListGrid_SelectedRowChanged(TipoDeEmpleado selectedModel)
        {
            _TipoDeEmpleadoListGridselectedvalue = selectedModel;
            _scriptsUser.OnSelectedRowChanged(selectedModel);
        }

        #endregion Selección de la data


        #region Navegación por celdas

        private async void TipoDeEmpleadoListGrid_CellNavigation((string fieldName, object value, string route) redirect)
        {
            string redirectRoute = $"{(redirect.route == string.Empty ? "/" : redirect.route)}?{redirect.fieldName}={redirect.value}";

            await JSRuntime.InvokeAsync<object>("OpenInNewtab", new object[2] { redirectRoute, "_blank" });
        }

        #endregion Navegación por celdas


        #region Alertas de la grid

        private void TipoDeEmpleadoListGrid_SetGridAlert(string message) 
        {
            if (_alerts != null)
            {
                _alerts.AddAlert(_TipoDeEmpleadoListGridListGrid, new WoFormAlertModel(message));
            }
        }

        #endregion Alertas de la grid
        #endregion TipoDeEmpleadoListGrid


    }

}


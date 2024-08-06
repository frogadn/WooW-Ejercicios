///------------------------------------------------------------------------------------------------------------------
/// Código autogenerado por la template WoTemplateGenericClass en el path WooW.SB\WooW.SB\BlazorGenerator\BlazorTemplates\CommonTemplates\Pages\WoTemplateLayoutPartialBlazor.tt
/// Genera código consistente con la version de la prueba de concepto a dia 05-10-2023 En Blazor Wasm y Server
/// Este código es auto generado y su modificación puede causar que el código no se comporte como deveria ademas de
/// que se perderan los cambios realizados en el código al momento de la generación.
///------------------------------------------------------------------------------------------------------------------
using WasmUnitModel_proj.ControlModels;
using WasmUnitModel_proj.FluentValidators;
using WasmUnitModel_proj.TransitionSettings;
using WasmUnitModel_proj.UserCode;
using DevExpress.CodeParser;
using DevExpress.Data;
using DevExpress.Emf.GraphicsPlayer;
using FluentValidation.Results;
using Microsoft.AspNetCore.WebUtilities;
using ServiceStack.Blazor.Components.Tailwind;
using System.Reflection;
using System.Text;
using WooW.Core;
using WooW.DTO;
using WooW.Model;
using Microsoft.AspNetCore.Components;
using WooW.Blazor;
using WooW.Blazor.Resources;
using WooW.Blazor.Services;
using Microsoft.JSInterop;
using Newtonsoft.Json;

namespace WasmUnitModel_proj.Pages
{
    
    public partial class WasmUnitModelLayout
    {

        #region Atributos

        // Inyección del runtime de JavaScript para ejecutar código js desde c#.
        [Inject]
        public IJSRuntime? JSRuntime { get; set; }

        // Código generado por el método BuildHeaderClass en la clase WoLayoutPartialGenerator.cs 

        /// <summary>
        /// Inyección de la clase con las vistas para manipular los controles.
        /// </summary>
        [Inject]
        public WasmUnitModelControls _modelControls { get; set; }


        /// <summary>
        /// Instancia con los métodos de los eventos de los controles.
        /// </summary>
        [Inject]
        public WasmUnitModelScriptsUser _scriptsUser { get; set; }


        /// <summary>
        /// Instancia con las configuraciones de bloqueo y desbloqueo de los controles de la clase.
        /// </summary>
        [Inject]
        private WasmUnitModelTransitionSettings _EmpleadoTransitionSettings { get; set; }

        /// <summary>
        /// Variable con el valor del parámetro del identificador que se puede recibir como parámetro.
        /// Indica en que registro se posicionara la navegación.
        /// </summary>
        private string _idParameter = string.Empty;

        /// <summary>
        /// Variable con el valor de la transición preseleccionada que se puede pasar como parámetro.
        /// Indica la transacción pre seleccionada
        /// </summary>
        private string _transition = string.Empty;

     #region Instancias de los scripts de otros formularios



     #endregion Instancias de los scripts de otros formularios

        #endregion Atributos



        #region Métodos adicionales
        // Código generado por el método BuildHeaderClass en la clase WoLayoutPartialGenerator.cs 

        /// <summary>
        /// Método que permite actualizar el formulario.
        /// Generado por el método BuildExtraMethodsForm en la clase WoLayoutPartialGenerator.cs 

        /// Solo realiza un re dibujado de la vista.
        /// </summary>
        private void UpdateEntireForm() => StateHasChanged();

        /// <summary>
        /// Indicador del primer renderizado de la vista.
        /// Permite controlar lo que se ejecuta en metodos sin esta bandera.
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

        #region Fluent
        // Código generado por el método BuildHeaderClass en la clase WoLayoutPartialGenerator.cs 

        /// <summary>
        /// Instancia de la clase con las reglas de fluent, permite la validación del objeto.
        /// <summary>
        private WasmUnitModelValidator _authValidator = new WasmUnitModelValidator();

        /// <summary>
        /// Guarda el resultado de la validación, los errores que contenga se asignaran a las alertas del componente.
        /// <summary>
        private ValidationResult? _authValidationResult;

        /// <summary>
        /// Se llama en cada uno de los métodos OnChange del modelo para validar el cambio del campo con fluent
        /// </summary>
        private void EmpleadoValidate(string id, dynamic control)
        {
            _authValidationResult = _authValidator.Validate(_scriptsUser.Empleado);
            bool noAlerts = true;

            foreach (var validation in _authValidationResult.Errors)
            {
                if (id == validation.PropertyName)
                {
                    noAlerts = false;
                    control.AgregarAlerta(validation.ToString());
                }
            }

            if (noAlerts)
            {
                control.LimpiarAlertas();
            }

        }

        #endregion Fluent


        #region Ciclo de vida

        /// Código generado por el método BuildOnInitialized en la clase WoLayoutPartialGenerator.cs 
        /// <summary>
        /// Se detona na damas iniciar la pantalla, re instancia el cliente a partir de los datos en el
        /// local storage y obtiene parámetros en el caso que de la url venga con ellos.
        /// </summary>
        /// <returns></returns>
        
        protected override async Task OnInitializedAsync()
        {

            /// Recuperación del parámetro del identificador para la navegación.
            Uri? uri = NavigationManager?.ToAbsoluteUri(NavigationManager.Uri);
         
            if (uri != null)
            {
                var queryStrings = QueryHelpers.ParseQuery(uri.Query);
         
                if (queryStrings.TryGetValue("__Id", out var id))
                {
                    _idParameter = id;
                }
                if (queryStrings.TryGetValue("__Transition", out var transition))
                {
                    _transition = transition;
                }
            }

            try
            {
                Client = await GetClientAsync();

                if (_firstRender)
                {
                    if (Client != null)
                    {
                        /// Asignamos el cliente a los scripts de usuario.
                        _scriptsUser.woTarget = Client;

                        /// Suscripción del evento de actualización de la vista.
                        _scriptsUser.StateHasChangeEvt += UpdateEntireForm;

                        /// Instancia de los clientes específicos de controles como lookups.
                        _navService = new WoNavigationService<Empleado, EmpleadoGet, EmpleadoList>(Client);
                        _transitionService = new WoTransitionService<Empleado>(Client);

                        _deleteService = new WoDeleteService<Empleado, EmpleadoBorrar>(Client);


                        try
                        {
                            /// En caso de venir un parámetro usamos el MoveTo, en caso contrario usamos el Last.
                            if (_idParameter == string.Empty)
                            {
                                await First_OnClick();
                            }
                            else
                            {
                                try
                                {
                                    await MoveTo();
                                }
                                catch (Exception ex)
                                {
                                    await First_OnClick();
                                    throw new Exception(ex.Message);
                                }
                            }

                            if (_transition != null && _transition != string.Empty)
                            {
                                ControlesTransition_OnChange(_transition);
                            }
                        }
                        catch (Exception ex)
                        {
                            _EmpleadoTransitionSettings.SetBlockSettings("NavigationModeNoReg");
                            throw new Exception(ex.Message);
                        }

                        /// Actualizamos el rendering de la vista con los datos de la consulta de navegación, ya sea
                        /// move to o last.
                        StateHasChanged();

                        /// Actualizamos el valor de la bandera para evitar que el código dentro del if se ejecute en cada state has change
                        _firstRender = false;
                    }
                }
            }
            catch (Exception ex)
            {
                /// En caso de error, se detona la alerta con la configuración de error.
                _modelControls.Alertas.AgregarAlerta(ex.Message, eTipoDeAlerta.Error, true);
            }


        }
            

        /// <summary>
        /// Se detona al terminar de dibujar los componentes.
        /// Asigna el modo de transición inicial en navigation.
        /// Código generado por el método BuildOnAfterRender en la clase WoLayoutPartialGenerator.cs 
        /// </summary>
        /// <param name="firstRender"></param>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);

            if(!Client.BearerToken.IsNullOrStringEmpty())
            {
                
            }

        
            if (firstRender)
            {
                _EmpleadoTransitionSettings.SetBlockSettings("NavigationMode");
            }
        }

        #endregion Ciclo de vida

        #region Controles

        // Este código fue generado por el fichero WoRecordToolBarPartial.cs.

        #region Servicios

        /// <summary>
        /// Servicio de navegación del record
        /// </summary>
        private WoNavigationService<Empleado, EmpleadoGet, EmpleadoList>? _navService;

        /// <summary>
        /// Servicio de transiciones del record.
        /// (Dispara la transición y envía el DTO)
        /// </summary>
        private WoTransitionService<Empleado>? _transitionService;

        /// <summary>
        /// Servicio del delete de los registros.
        /// Solo aplicable a alguno de los formularios (Catálogos, mientras no aya referencias).
        /// </summary>
        private WoDeleteService<Empleado, EmpleadoBorrar>? _deleteService;

        #endregion Servicios


        #region Controles

        /// <summary>
        /// Botones de navegación entre registros.
        /// </summary>
        /// <returns></returns>
        private async Task First_OnClick()
        {
            
            try
            {
                if (_navService != null)
                {
                    Empleado result = await _navService.FirstAsync();
                    if (result != null)
                    {
                        _scriptsUser.Empleado = result;
                        _EmpleadoTransitionSettings.SetBlockSettings("NavigationMode");

                        _currentTransition = null;
                        _transitionsCol = _dataTransitionsControles.Where(x => x.TargetWoState.ToString() == result.WoState.ToString()).FirstOrDefault()?.AvailableTransitions ?? new List<WoTransitionWrapper>();

                        LkpTipoDeEmpleadoId_NavigationMode();


                        _modelControls.Controles.EstadoBtnPrimeroHabilitado(false);
                        _modelControls.Controles.EstadoBtnAnteriorHabilitado(false);
                        _modelControls.Controles.EstadoBtnSiguienteHabilitado(true);
                        _modelControls.Controles.EstadoBtnUltimoHabilitado(true);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "Error Last click: No se encontraron datos")
                    _modelControls.Alertas.AgregarAlerta(ex.Message, eTipoDeAlerta.Mensaje, true);
                else
                    _modelControls.Alertas.AgregarAlerta(ex.Message, eTipoDeAlerta.Error, true);
            }
            
        }

        private async Task Prior_OnClick()
        {
            
            try
            {
                if (_navService != null)
                {
                    (Empleado Model, bool IsFirst) result = await _navService.PriorAsync();
                    if (result.Model != null)
                    {
                        _scriptsUser.Empleado = result.Model;
                        _EmpleadoTransitionSettings.SetBlockSettings("NavigationMode");

                        _currentTransition = null;
                        _transitionsCol = _dataTransitionsControles.Where(x => x.TargetWoState.ToString() == result.Model.WoState.ToString()).FirstOrDefault()?.AvailableTransitions ?? new List<WoTransitionWrapper>();

                        LkpTipoDeEmpleadoId_NavigationMode();


                        if (result.IsFirst)
                        {
                            _modelControls.Controles.EstadoBtnPrimeroHabilitado(false);
                            _modelControls.Controles.EstadoBtnAnteriorHabilitado(false);
                            _modelControls.Controles.EstadoBtnSiguienteHabilitado(true);
                            _modelControls.Controles.EstadoBtnUltimoHabilitado(true);
                        }
                        else
                        {
                            _modelControls.Controles.EstadoBtnPrimeroHabilitado(true);
                            _modelControls.Controles.EstadoBtnAnteriorHabilitado(true);
                            _modelControls.Controles.EstadoBtnSiguienteHabilitado(true);
                            _modelControls.Controles.EstadoBtnUltimoHabilitado(true);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "Error Last click: No se encontraron datos")
                    _modelControls.Alertas.AgregarAlerta(ex.Message, eTipoDeAlerta.Mensaje, true);
                else
                    _modelControls.Alertas.AgregarAlerta(ex.Message, eTipoDeAlerta.Error, true);
            }
            
        }

        private async Task Next_OnClick()
        {
            try
            {
                if (_navService != null)
                {
                    (Empleado Model, bool IsLast) result = await _navService.NextAsync();
                    if (result.Model != null)
                    {
                        _scriptsUser.Empleado = result.Model;
                        _EmpleadoTransitionSettings.SetBlockSettings("NavigationMode");

                        _currentTransition = null;
                        _transitionsCol = _dataTransitionsControles.Where(x => x.TargetWoState.ToString() == result.Model.WoState.ToString()).FirstOrDefault()?.AvailableTransitions ?? new List<WoTransitionWrapper>();

                        LkpTipoDeEmpleadoId_NavigationMode();


                        if (result.IsLast)
                        {
                            _modelControls.Controles.EstadoBtnPrimeroHabilitado(true);
                            _modelControls.Controles.EstadoBtnAnteriorHabilitado(true);
                            _modelControls.Controles.EstadoBtnSiguienteHabilitado(false);
                            _modelControls.Controles.EstadoBtnUltimoHabilitado(false);
                        }
                        else
                        {
                            _modelControls.Controles.EstadoBtnPrimeroHabilitado(true);
                            _modelControls.Controles.EstadoBtnAnteriorHabilitado(true);
                            _modelControls.Controles.EstadoBtnSiguienteHabilitado(true);
                            _modelControls.Controles.EstadoBtnUltimoHabilitado(true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "Error Last click: No se encontraron datos")
                    _modelControls.Alertas.AgregarAlerta(ex.Message, eTipoDeAlerta.Mensaje, true);
                else
                    _modelControls.Alertas.AgregarAlerta(ex.Message, eTipoDeAlerta.Error, true);
            }   
        }

        private async Task Last_OnClick()
        {
            
            try
            {
                if (_navService != null)
                {
                    Empleado result = await _navService.LastAsync();
                    if (result != null)
                    {
                        _scriptsUser.Empleado = result;
                        _EmpleadoTransitionSettings.SetBlockSettings("NavigationMode");

                        _currentTransition = null;
                        _transitionsCol = _dataTransitionsControles.Where(x => x.TargetWoState.ToString() == result.WoState.ToString()).FirstOrDefault()?.AvailableTransitions ?? new List<WoTransitionWrapper>();

                        LkpTipoDeEmpleadoId_NavigationMode();


                        _modelControls.Controles.EstadoBtnPrimeroHabilitado(true);
                        _modelControls.Controles.EstadoBtnAnteriorHabilitado(true);
                        _modelControls.Controles.EstadoBtnSiguienteHabilitado(false);
                        _modelControls.Controles.EstadoBtnUltimoHabilitado(false);

                    }
                }
            }
            catch (Exception ex)
            {
                _EmpleadoTransitionSettings.SetBlockSettings("NavigationModeNoReg");
                _scriptsUser.Empleado = new Empleado();

                if (ex.Message == "Error Last click: No se encontraron datos")
                    _modelControls.Alertas.AgregarAlerta(ex.Message, eTipoDeAlerta.Mensaje, true);
                else
                    _modelControls.Alertas.AgregarAlerta(ex.Message, eTipoDeAlerta.Error, true);
            }
            
        }

        private async Task MoveTo()
        {
            
            try
            {
                if (_navService != null)
                {
                    (Empleado? model, bool isFirst, bool isLast) result = await _navService.GetModelByParameter(_idParameter);
                    if (result.model != null)
                    {
                        _scriptsUser.Empleado = result.model;
                        _EmpleadoTransitionSettings.SetBlockSettings("NavigationMode");

                        LkpTipoDeEmpleadoId_NavigationMode();


                        _currentTransition = null;
                        _transitionsCol = _dataTransitionsControles.Where(x => x.TargetWoState.ToString() == result.model.WoState.ToString()).FirstOrDefault()?.AvailableTransitions ?? new List<WoTransitionWrapper>();

                        _modelControls.Controles.EstadoBtnPrimeroHabilitado(!result.isFirst);
                        _modelControls.Controles.EstadoBtnAnteriorHabilitado(!result.isFirst);
                        _modelControls.Controles.EstadoBtnSiguienteHabilitado(!result.isLast);
                        _modelControls.Controles.EstadoBtnUltimoHabilitado(!result.isLast);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($@"El identificador {_idParameter} que esta intentando buscar no se encontró: {ex.Message}");
            }
            
        }

        #endregion Controles


        #region Status

        /// <summary>
        /// Instancia del control de la barra de navegación (tool bar).
        /// </summary>
        private WoFormToolbar<App>? _ftbControles;

        /// <summary>
        /// Suscribe los eventos de la vista a la barra de navegación.
        /// </summary>
        public void SetStatusControles()
        {
            if (_ftbControles != null)
            {
                _modelControls.Controles.ChangeNavigationEnabledEvt += _ftbControles.SetEnabledNavigation;
                _modelControls.Controles.ChangeTransitionEnabledEvt += _ftbControles.SetEnabledTransition;
                _modelControls.Controles.ChangeTransitionButtonsEnabledEvt += _ftbControles.SetEnabledBtnTransition;
                _modelControls.Controles.ChangeBtnFirstEnabledEvt += _ftbControles.SetEnabledFirstBtn;
                _modelControls.Controles.ChangeBtnPriorEnabledEvt += _ftbControles.SetEnabledPriorBtn;
                _modelControls.Controles.ChangeBtnNextEnabledEvt += _ftbControles.SetEnabledNextBtn;
                _modelControls.Controles.ChangeBtnLastEnabledEvt += _ftbControles.SetEnabledLastBtn;
                _modelControls.Controles.ChangeDeleteButtonsEnabledEvt += _ftbControles.SetEnabledDeleteBtn;
            }
        }

        #endregion Status


        #region Transiciones

        /// <summary>
        /// Transición seleccionada en el combo
        /// </summary>
        private string? _currentTransition;

        /// <summary>
        /// Lista con las Transiciones interna posibles a partir de una Transición.
        /// </summary>
        private IEnumerable<WoTransitionWrapper> _transitionsCol = new List<WoTransitionWrapper>() {                    new WoTransitionWrapper { Id = "Nuevo", Label = "DarDeAlta" },};
        /// <summary>
        /// Lista con las Transiciones que se pueden realizar y las que se cargan en el control.
        /// Todas las Transiciones del diagrama de estados.
        /// </summary>
        private IEnumerable<WoTransitionModel> _dataTransitionsControles = new List<WoTransitionModel>()
        {


            new WoTransitionModel() { 
                TransitionName = "Nuevo", 
                TriggersPopup = false, 
                TargetWoState = (eEmpleado_WoState)100, 
                DtoType = typeof(EmpleadoNuevo),
                AvailableTransitions = new List<WoTransitionWrapper> 
                {

                    new WoTransitionWrapper { Id = "Nuevo", Label = "DarDeAlta" },
                    new WoTransitionWrapper {Id = "Suspender", Label = "Suspender"}, 
                    new WoTransitionWrapper {Id = "Modificar", Label = "Modificar"}, 


                }
,
                IsNew = true
            },


            new WoTransitionModel() { 
                TransitionName = "Activar", 
                TriggersPopup = false, 
                TargetWoState = (eEmpleado_WoState)100, 
                DtoType = typeof(EmpleadoActivar),
                AvailableTransitions = new List<WoTransitionWrapper> 
                {

                    new WoTransitionWrapper { Id = "Nuevo", Label = "DarDeAlta" },
                    new WoTransitionWrapper {Id = "Suspender", Label = "Suspender"}, 
                    new WoTransitionWrapper {Id = "Modificar", Label = "Modificar"}, 


                }

            },


            new WoTransitionModel() { 
                TransitionName = "Suspender", 
                TriggersPopup = false, 
                TargetWoState = (eEmpleado_WoState)500, 
                DtoType = typeof(EmpleadoSuspender),
                AvailableTransitions = new List<WoTransitionWrapper> 
                {

                    new WoTransitionWrapper { Id = "Nuevo", Label = "DarDeAlta" },
                    new WoTransitionWrapper {Id = "Activar", Label = "Activar"}, 
                    new WoTransitionWrapper {Id = "DarDeBaja", Label = "DarDeBaja"}, 


                }

            },


            new WoTransitionModel() { 
                TransitionName = "DarDeBaja", 
                TriggersPopup = false, 
                TargetWoState = (eEmpleado_WoState)600, 
                DtoType = typeof(EmpleadoDarDeBaja),
                AvailableTransitions = new List<WoTransitionWrapper> 
                {

                    new WoTransitionWrapper { Id = "Nuevo", Label = "DarDeAlta" },


                }

            },


            new WoTransitionModel() { 
                TransitionName = "Modificar", 
                TriggersPopup = false, 
                TargetWoState = (eEmpleado_WoState)100, 
                DtoType = typeof(EmpleadoModificar),
                AvailableTransitions = new List<WoTransitionWrapper> 
                {

                    new WoTransitionWrapper { Id = "Nuevo", Label = "DarDeAlta" },
                    new WoTransitionWrapper {Id = "Suspender", Label = "Suspender"}, 
                    new WoTransitionWrapper {Id = "Modificar", Label = "Modificar"}, 


                }

            },



        };

        #endregion Transiciones


        #region Cambio de transición

        /// <summary>
        /// Método que se detona al seleccionar una nueva transición del toolbar.
        /// </summary>
        /// <param name="newValue"></param>
        private void ControlesTransition_OnChange(string newValue)
        {
            WoTransitionModel? transitionSelected = null;
            if (_dataTransitionsControles != null)
            {
                transitionSelected = _dataTransitionsControles.Where(x => x.TransitionName == newValue).FirstOrDefault();
            }

            if (transitionSelected != null)
            {
                _currentTransition = newValue;

                if (newValue != null)
                {
                    _EmpleadoTransitionSettings.SetBlockSettings(_currentTransition);
                    if (transitionSelected.IsNew)
                    {
                        _scriptsUser.Empleado = new Empleado();


                    }

                    _scriptsUser.Empleado.WoState = (eEmpleado_WoState)transitionSelected.TargetWoState;

                    _scriptsUser.Transicion = _currentTransition;

                }
            }
        }



        /// <summary>
        /// Envía alertas al control de alertas en función de los resultados y el poseso interno del record.
        /// </summary>
        /// <param name="alert"></param>
        private void SendTransitionAlert(string alert)
        {
            if (_alerts != null)
            {
                if (alert == "ok")
                {
                    _modelControls.Alertas.AgregarAlerta($@"La transición se realizo correctamente.", eTipoDeAlerta.Ok);
                }
                else if (alert == "No Existen mas registros disponibles.")
                {
                    _modelControls.Alertas.AgregarAlerta(alert, eTipoDeAlerta.Mensaje, siempreEnPantalla: false, tiempo: 3);
                }
                else
                {
                    _modelControls.Alertas.AgregarAlerta(alert, eTipoDeAlerta.Error, siempreEnPantalla: true);
                }
            }
        }

        #endregion Cambio de transición


        #region Botón de ejecución;

        /// <summary>
        /// Botón que ejecuta el comando de la transición seleccionada.
        /// </summary>
        /// <param name="model"></param>
        private async Task ControlesExecute_OnClick()
        {
            
            if (_transitionService != null)
            {
                if (_currentTransition != null)
                {
                    Type? dtoType = _dataTransitionsControles.Where(x => x.TransitionName == _currentTransition).FirstOrDefault()?.DtoType;
                    bool isNew = _dataTransitionsControles.Where(x => x.TransitionName == _currentTransition).FirstOrDefault()?.IsNew ?? false;

                    if (dtoType != null)
                    {
                        try
                        {      



                            Empleado? result = await _transitionService.CommitTransition(dtoType, _scriptsUser.Empleado, isNew);

                            if (_navService != null)
                            {
                                if (result != null)
                                {
                                    _scriptsUser.Empleado = result;
                                    _navService.LastValidId = result.Id;
                                    _currentTransition = null;
                                    _EmpleadoTransitionSettings.SetBlockSettings("NavigationMode");
                                    _modelControls.Alertas.AgregarAlerta($@"Transicion {_currentTransition} se realizo con exito", eTipoDeAlerta.Ok);

                                    _transitionsCol = _dataTransitionsControles.Where(x => x.TargetWoState.ToString() == result.WoState.ToString()).FirstOrDefault()?.AvailableTransitions ?? new List<WoTransitionWrapper>();

                                    _scriptsUser.Transicion = "Navegacion";
                                }
                                else
                                {
                                    _modelControls.Alertas.AgregarAlerta($@"Ocurrió un error al intentar recuperar el result");
                                }
                            }
                            else
                            {
                                _modelControls.Alertas.AgregarAlerta($@"Ocurrió un error al intentar recuperar el Servicio de Navegación");
                            }
                        }
                        catch (Exception ex)
                        {
                            _modelControls.Alertas.AgregarAlerta($@"Ocurrió un error: {ex.Message}", eTipoDeAlerta.Error, true);
                        }
                    }
                    else
                    {
                        _modelControls.Alertas.AgregarAlerta("No se ha encontrado el tipo de DTO.", eTipoDeAlerta.Error, true);
                    }
                }
                else
                {
                    _modelControls.Alertas.AgregarAlerta("No se ha seleccionado una transición.", eTipoDeAlerta.Error, true);
                }
            }
            else
            {
                _modelControls.Alertas.AgregarAlerta("No se ha inicializado el servicio de transiciones.", eTipoDeAlerta.Error, true);
            }

        }
        #endregion Botón de ejecución;


        #region Botón de cancel

        /// <summary>
        /// Botón que cancela la transición seleccionada.
        /// </summary>
        /// <param name="model"></param>
        private async Task ControlesCancel_OnClick()
        {
            
            try
            {
                if (_navService != null)
                {
                   
                    if (_navService.LastValidId == null || _navService.LastValidId == string.Empty)
                    {
                        _EmpleadoTransitionSettings.SetBlockSettings("NavigationModeNoReg");
                        _currentTransition = null;
                        _modelControls.Alertas.AgregarAlerta($@"No hay registros", eTipoDeAlerta.Mensaje);
                    }
                    else
                    {
                        Empleado? result = await _navService?.GetModelById(_navService.LastValidId);

                        if (result != null)
                        {
                            _scriptsUser.Empleado = result;
                            _EmpleadoTransitionSettings.SetBlockSettings("NavigationMode");
                            _currentTransition = null;
                        }
                    }
                }
                else
                {
                    _modelControls.Alertas.AgregarAlerta($@"Ocurrió un error al intentar recuperar el Servicio de Navegación");
                }
            }
            catch (Exception ex)
            {
                _modelControls.Alertas.AgregarAlerta($@"Ocurrió un error en el CancelOnClick (Blazor): {ex.Message}");
            }

            _scriptsUser.Transicion = "Navegacion";

        }

        #endregion Botón de cancel


        #region botón Compartir

        /// <summary>
        /// Servicio de acceso al porta papeles para copiar la data al porta papeles.
        /// </summary>
        private WoShareButton<App>? _wsbCopiar;

        private void SetStatusWsbCopiar()
        {
            if (_wsbCopiar != null)
            {
                _modelControls.Compartir.ChangeShareEnabledEvt += _wsbCopiar.SetShareEnabled;
            }
        }

        #endregion botón Compartir


        #region botón Eliminar

        private async Task ControlesDelete_OnClick()
        {
            try
            {
                if (_deleteService != null)
                {
                    Empleado? deleteResult = await _deleteService.DeleteTransition(_scriptsUser.Empleado);
                    if (deleteResult != null)
                    {
                        _modelControls.Alertas.AgregarAlerta($@"Se elimino el registro con el id {deleteResult.Id} con exito", eTipoDeAlerta.Ok);
                        await Last_OnClick();
                    }
                    else
                    {
                        throw new Exception($@"No se pudo eliminar el registro con el id {_scriptsUser.Empleado.Id}");
                    }
                }
            }
            catch (Exception ex)
            {
                _modelControls.Alertas.AgregarAlerta($@"Ocurrió un error en el ControlsDelete_OnClick (Blazor): {ex.Message}", eTipoDeAlerta.Error, true);
            }
        }

        #endregion botón Eliminar

        #endregion Controles


        #region Root

        // Este código fue generado por el fichero WoFormPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorContainers\WoForm\WoFormPartial.cs
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoForm? _wfRoot;


        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusWfRoot()
        {
            if (_wfRoot != null)
            {
                _modelControls.Root.ChangeFontWeightEvt += _wfRoot.ChangeFontWeight;
                _modelControls.Root.ChangeFontItalicEvt += _wfRoot.ChangeFontItalic;
                _modelControls.Root.ChangeFontDecorationEvt += _wfRoot.ChangeFontDecoration;
                _modelControls.Root.ChangeFontColorEvt += _wfRoot.ChangeFontColor;
                _modelControls.Root.ChangeBackColorEvt += _wfRoot.ChangeBackgroundColor;

                _modelControls.Root.ActualizarComponente();
                CheckForm();
            }
        }

        #endregion Root

        #region formFormModel

        // Este código fue generado por el fichero WoFormTabPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorContainers\WoFormTab\WoFormTabPartial.cs
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoFormTab? _wftformFormModel;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusWftformFormModel()
        {
            if (_wftformFormModel != null)
            {
                _modelControls.formFormModel.ChangeFontWeightEvt += _wftformFormModel.ChangeFontWeight;
                _modelControls.formFormModel.ChangeFontItalicEvt += _wftformFormModel.ChangeFontItalic;
                _modelControls.formFormModel.ChangeFontDecorationEvt += _wftformFormModel.ChangeFontDecoration;
                _modelControls.formFormModel.ChangeFontColorEvt += _wftformFormModel.ChangeFontColor;
                _modelControls.formFormModel.ChangeBackColorEvt += _wftformFormModel.ChangeBackgroundColor;

                _modelControls.formFormModel.ActualizarComponente();
                CheckForm();
            }
        }

        #endregion formFormModel

        #region formControlform

        // Este código fue generado por el fichero WoFormTabPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorContainers\WoFormTab\WoFormTabPartial.cs
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoFormTab? _wftformControlform;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusWftformControlform()
        {
            if (_wftformControlform != null)
            {
                _modelControls.formControlform.ChangeFontWeightEvt += _wftformControlform.ChangeFontWeight;
                _modelControls.formControlform.ChangeFontItalicEvt += _wftformControlform.ChangeFontItalic;
                _modelControls.formControlform.ChangeFontDecorationEvt += _wftformControlform.ChangeFontDecoration;
                _modelControls.formControlform.ChangeFontColorEvt += _wftformControlform.ChangeFontColor;
                _modelControls.formControlform.ChangeBackColorEvt += _wftformControlform.ChangeBackgroundColor;

                _modelControls.formControlform.ActualizarComponente();
                CheckForm();
            }
        }

        #endregion formControlform


        #region Id

        // Este código fue generado por el fichero WoTextEditPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditPartial.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoTextEdit<App>? _txtId;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusTxtId()
        {
            if (_txtId != null)
            {
                _modelControls.Id.ChangeEnabledEvt += _txtId.ChangeStatus;
                _modelControls.Id.ChangeSizeEvt += _txtId.ChangeFontSize;
        
                _modelControls.Id.ChangeControlFontColorEvt += _txtId.ChangeControlFontColor;
                _modelControls.Id.ChangeControlFontWeightEvt += _txtId.ChangeControlFontWeight;
                _modelControls.Id.ChangeControlFontItalicEvt += _txtId.ChangeControlFontItalic;
                _modelControls.Id.ChangeControlFontDecorationEvt += _txtId.ChangeControlFontDecoration;
        
                _modelControls.Id.ChangeBackColorEvt += _txtId.ChangeBackgroundColor;
        
                _modelControls.Id.ActualizarComponente();
                CheckForm();
            }
        }

        /// <summary>
        /// Referencia del contenedor del item.
        /// </summary>
        private WoFormItem? _fliId;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del contenedor a los 
        /// eventos del contenedor a través de la referencia.
        /// </summary>
        /// <param name="status"></param>
        public void SetStatusFliId()
        {
            if (_fliId != null)
            {
                _modelControls.IdContainer.ChangeCaptionFontColorEvt += _fliId.ChangeCaptionFontColor;
                _modelControls.IdContainer.ChangeCaptionFontWeightEvt += _fliId.ChangeCaptionFontWeight;
                _modelControls.IdContainer.ChangeCaptionFontItalicEvt += _fliId.ChangeCaptionFontItalic;
                _modelControls.IdContainer.ChangeCaptionFontDecorationEvt += _fliId.ChangeCaptionFontDecoration;
                _modelControls.IdContainer.ChangeSizeEvt += _fliId.ChangeFontSize;
            }
        }

        /// <summary>
        /// Referencia de la alerta del item.
        /// </summary>
        private WoInputAlert? _wiaId;

         /// <summary>
         /// Suscribe los controladores de eventos de la vista a los eventos de la alerta a través de la referencia.
         /// </summary>
         public void SetStatusWiaId()
         {
             if (_wiaId != null)
             {
                 _modelControls.IdAlert.SetAlertValueEvt += _wiaId.SetAlertValue;
                 _modelControls.IdAlert.ClearAlertsEvt += _wiaId.ClearAlerts;
             }
         }

        /// <summary>
        /// Evento del componente que se ejecuta cuando se modifica el valor del componente Id.
        /// </summary>
        public void Id_OnChange(string newValue)
        {
            _scriptsUser.Empleado.Id = newValue;
            EmpleadoValidate("Id", _modelControls.IdAlert);
            _scriptsUser.Id_OnChange();
        }

        #endregion Id

        #region Nombre

        // Este código fue generado por el fichero WoTextEditPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditPartial.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoTextEdit<App>? _txtNombre;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusTxtNombre()
        {
            if (_txtNombre != null)
            {
                _modelControls.Nombre.ChangeEnabledEvt += _txtNombre.ChangeStatus;
                _modelControls.Nombre.ChangeSizeEvt += _txtNombre.ChangeFontSize;
        
                _modelControls.Nombre.ChangeControlFontColorEvt += _txtNombre.ChangeControlFontColor;
                _modelControls.Nombre.ChangeControlFontWeightEvt += _txtNombre.ChangeControlFontWeight;
                _modelControls.Nombre.ChangeControlFontItalicEvt += _txtNombre.ChangeControlFontItalic;
                _modelControls.Nombre.ChangeControlFontDecorationEvt += _txtNombre.ChangeControlFontDecoration;
        
                _modelControls.Nombre.ChangeBackColorEvt += _txtNombre.ChangeBackgroundColor;
        
                _modelControls.Nombre.ActualizarComponente();
                CheckForm();
            }
        }

        /// <summary>
        /// Referencia del contenedor del item.
        /// </summary>
        private WoFormItem? _fliNombre;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del contenedor a los 
        /// eventos del contenedor a través de la referencia.
        /// </summary>
        /// <param name="status"></param>
        public void SetStatusFliNombre()
        {
            if (_fliNombre != null)
            {
                _modelControls.NombreContainer.ChangeCaptionFontColorEvt += _fliNombre.ChangeCaptionFontColor;
                _modelControls.NombreContainer.ChangeCaptionFontWeightEvt += _fliNombre.ChangeCaptionFontWeight;
                _modelControls.NombreContainer.ChangeCaptionFontItalicEvt += _fliNombre.ChangeCaptionFontItalic;
                _modelControls.NombreContainer.ChangeCaptionFontDecorationEvt += _fliNombre.ChangeCaptionFontDecoration;
                _modelControls.NombreContainer.ChangeSizeEvt += _fliNombre.ChangeFontSize;
            }
        }

        /// <summary>
        /// Referencia de la alerta del item.
        /// </summary>
        private WoInputAlert? _wiaNombre;

         /// <summary>
         /// Suscribe los controladores de eventos de la vista a los eventos de la alerta a través de la referencia.
         /// </summary>
         public void SetStatusWiaNombre()
         {
             if (_wiaNombre != null)
             {
                 _modelControls.NombreAlert.SetAlertValueEvt += _wiaNombre.SetAlertValue;
                 _modelControls.NombreAlert.ClearAlertsEvt += _wiaNombre.ClearAlerts;
             }
         }

        /// <summary>
        /// Evento del componente que se ejecuta cuando se modifica el valor del componente Nombre.
        /// </summary>
        public void Nombre_OnChange(string newValue)
        {
            _scriptsUser.Empleado.Nombre = newValue;
            EmpleadoValidate("Nombre", _modelControls.NombreAlert);
            _scriptsUser.Nombre_OnChange();
        }

        #endregion Nombre

        #region FechaDeNacimiento

        // Este código fue generado por el fichero WoDateEditPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoDateEdit\WoDateEditPartial.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoDateEdit<DateTime,App>? _dteFechaDeNacimiento;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusDteFechaDeNacimiento()
        {
            if (_dteFechaDeNacimiento != null)
            {
                _modelControls.FechaDeNacimiento.ChangeEnabledEvt += _dteFechaDeNacimiento.ChangeStatus;
                _modelControls.FechaDeNacimiento.ChangeSizeEvt += _dteFechaDeNacimiento.ChangeFontSize;

                _modelControls.FechaDeNacimiento.ChangeControlFontColorEvt += _dteFechaDeNacimiento.ChangeControlFontColor;
                _modelControls.FechaDeNacimiento.ChangeControlFontWeightEvt += _dteFechaDeNacimiento.ChangeControlFontWeight;
                _modelControls.FechaDeNacimiento.ChangeControlFontItalicEvt += _dteFechaDeNacimiento.ChangeControlFontItalic;
                _modelControls.FechaDeNacimiento.ChangeControlFontDecorationEvt += _dteFechaDeNacimiento.ChangeControlFontDecoration;

                _modelControls.FechaDeNacimiento.ChangeBackColorEvt += _dteFechaDeNacimiento.ChangeBackgroundColor;

                _modelControls.FechaDeNacimiento.ActualizarComponente();
                CheckForm();
            }
        }

        /// <summary>
        /// Referencia del contenedor del item.
        /// </summary>
        private WoFormItem? _fliFechaDeNacimiento;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del contenedor a los 
        /// eventos del contenedor a través de la referencia.
        /// </summary>
        /// <param name="status"></param>
        public void SetStatusFliFechaDeNacimiento()
        {
            if (_fliFechaDeNacimiento != null)
            {
                _modelControls.FechaDeNacimientoContainer.ChangeCaptionFontColorEvt += _fliFechaDeNacimiento.ChangeCaptionFontColor;
                _modelControls.FechaDeNacimientoContainer.ChangeCaptionFontWeightEvt += _fliFechaDeNacimiento.ChangeCaptionFontWeight;
                _modelControls.FechaDeNacimientoContainer.ChangeCaptionFontItalicEvt += _fliFechaDeNacimiento.ChangeCaptionFontItalic;
                _modelControls.FechaDeNacimientoContainer.ChangeCaptionFontDecorationEvt += _fliFechaDeNacimiento.ChangeCaptionFontDecoration;
                _modelControls.FechaDeNacimientoContainer.ChangeSizeEvt += _fliFechaDeNacimiento.ChangeFontSize;
            }
        }

        /// <summary>
        /// Referencia de la alerta del item.
        /// </summary>
        private WoInputAlert? _wiaFechaDeNacimiento;

         /// <summary>
         /// Suscribe los controladores de eventos de la vista a los eventos de la alerta a través de la referencia.
         /// </summary>
         public void SetStatusWiaFechaDeNacimiento()
         {
             if (_wiaFechaDeNacimiento != null)
             {
                 _modelControls.FechaDeNacimientoAlert.SetAlertValueEvt += _wiaFechaDeNacimiento.SetAlertValue;
                 _modelControls.FechaDeNacimientoAlert.ClearAlertsEvt += _wiaFechaDeNacimiento.ClearAlerts;
             }
         }

        /// <summary>
        /// Evento del componente que se ejecuta cuando se modifica el valor del componente FechaDeNacimiento.
        /// </summary>
        public void FechaDeNacimiento_OnChange(DateTime newValue)
        {
            _scriptsUser.Empleado.FechaDeNacimiento = newValue;
            EmpleadoValidate("FechaDeNacimiento", _modelControls.FechaDeNacimientoAlert);
            _scriptsUser.FechaDeNacimiento_OnChange();
        }
        #endregion FechaDeNacimiento

        #region EstadoCivil

        // Este código fue generado por el fichero WoComboEnumEditPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoComboEnumEdit\WoComboEnumEditPartial.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoComboEnumEdit<eEmpleado_EstadoCivil, App>? _cmbEstadoCivil;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusCmbEstadoCivil()
        {
            if (_cmbEstadoCivil != null)
            {
                _modelControls.EstadoCivil.ChangeEnabledEvt += _cmbEstadoCivil.ChangeStatus;
                _modelControls.EstadoCivil.ChangeSizeEvt += _cmbEstadoCivil.ChangeFontSize;

                _modelControls.EstadoCivil.ChangeControlFontColorEvt += _cmbEstadoCivil.ChangeControlFontColor;
                _modelControls.EstadoCivil.ChangeControlFontWeightEvt += _cmbEstadoCivil.ChangeControlFontWeight;
                _modelControls.EstadoCivil.ChangeControlFontItalicEvt += _cmbEstadoCivil.ChangeControlFontItalic;
                _modelControls.EstadoCivil.ChangeControlFontDecorationEvt += _cmbEstadoCivil.ChangeControlFontDecoration;

                _modelControls.EstadoCivil.ChangeBackColorEvt += _cmbEstadoCivil.ChangeBackgroundColor;

                _modelControls.EstadoCivil.ActualizarComponente();
                CheckForm();
            }
        }

        /// <summary>
        /// Referencia del contenedor del item.
        /// </summary>
        private WoFormItem? _fliEstadoCivil;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del contenedor a los 
        /// eventos del contenedor a través de la referencia.
        /// </summary>
        /// <param name="status"></param>
        public void SetStatusFliEstadoCivil()
        {
            if (_fliEstadoCivil != null)
            {
                _modelControls.EstadoCivilContainer.ChangeCaptionFontColorEvt += _fliEstadoCivil.ChangeCaptionFontColor;
                _modelControls.EstadoCivilContainer.ChangeCaptionFontWeightEvt += _fliEstadoCivil.ChangeCaptionFontWeight;
                _modelControls.EstadoCivilContainer.ChangeCaptionFontItalicEvt += _fliEstadoCivil.ChangeCaptionFontItalic;
                _modelControls.EstadoCivilContainer.ChangeCaptionFontDecorationEvt += _fliEstadoCivil.ChangeCaptionFontDecoration;
                _modelControls.EstadoCivilContainer.ChangeSizeEvt += _fliEstadoCivil.ChangeFontSize;
            }
        }

        /// <summary>
        /// Referencia de la alerta del item.
        /// </summary>
        private WoInputAlert? _wiaEstadoCivil;

         /// <summary>
         /// Suscribe los controladores de eventos de la vista a los eventos de la alerta a través de la referencia.
         /// </summary>
         public void SetStatusWiaEstadoCivil()
         {
             if (_wiaEstadoCivil != null)
             {
                 _modelControls.EstadoCivilAlert.SetAlertValueEvt += _wiaEstadoCivil.SetAlertValue;
                 _modelControls.EstadoCivilAlert.ClearAlertsEvt += _wiaEstadoCivil.ClearAlerts;
             }
         }

        /// <summary>
        /// Evento del componente que se ejecuta cuando se modifica el valor del componente EstadoCivil.
        /// </summary>
        public void EstadoCivil_OnChange(eEmpleado_EstadoCivil newValue)
        {
            _scriptsUser.Empleado.EstadoCivil = newValue;
            EmpleadoValidate("EstadoCivil", _modelControls.EstadoCivilAlert);
            _scriptsUser.EstadoCivil_OnChange();
        }
        #endregion EstadoCivil

        #region Salario

        // Este código fue generado por el fichero WoMaskedEditPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoMaskedEdit\WoMaskedEditPartial.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoMaskedEdit<Decimal, App>? _mkdSalario;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusMkdSalario()
        {
            if (_mkdSalario != null)
            {
                _modelControls.Salario.ChangeEnabledEvt += _mkdSalario.ChangeStatus;
                _modelControls.Salario.ChangeSizeEvt += _mkdSalario.ChangeFontSize;

                _modelControls.Salario.ChangeControlFontColorEvt += _mkdSalario.ChangeControlFontColor;
                _modelControls.Salario.ChangeControlFontWeightEvt += _mkdSalario.ChangeControlFontWeight;
                _modelControls.Salario.ChangeControlFontItalicEvt += _mkdSalario.ChangeControlFontItalic;
                _modelControls.Salario.ChangeControlFontDecorationEvt += _mkdSalario.ChangeControlFontDecoration;

                _modelControls.Salario.ChangeBackColorEvt += _mkdSalario.ChangeBackgroundColor;

                _modelControls.Salario.ActualizarComponente();
                CheckForm();
            }
        }

        /// <summary>
        /// Referencia del contenedor del item.
        /// </summary>
        private WoFormItem? _fliSalario;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del contenedor a los 
        /// eventos del contenedor a través de la referencia.
        /// </summary>
        /// <param name="status"></param>
        public void SetStatusFliSalario()
        {
            if (_fliSalario != null)
            {
                _modelControls.SalarioContainer.ChangeCaptionFontColorEvt += _fliSalario.ChangeCaptionFontColor;
                _modelControls.SalarioContainer.ChangeCaptionFontWeightEvt += _fliSalario.ChangeCaptionFontWeight;
                _modelControls.SalarioContainer.ChangeCaptionFontItalicEvt += _fliSalario.ChangeCaptionFontItalic;
                _modelControls.SalarioContainer.ChangeCaptionFontDecorationEvt += _fliSalario.ChangeCaptionFontDecoration;
                _modelControls.SalarioContainer.ChangeSizeEvt += _fliSalario.ChangeFontSize;
            }
        }

        /// <summary>
        /// Referencia de la alerta del item.
        /// </summary>
        private WoInputAlert? _wiaSalario;

         /// <summary>
         /// Suscribe los controladores de eventos de la vista a los eventos de la alerta a través de la referencia.
         /// </summary>
         public void SetStatusWiaSalario()
         {
             if (_wiaSalario != null)
             {
                 _modelControls.SalarioAlert.SetAlertValueEvt += _wiaSalario.SetAlertValue;
                 _modelControls.SalarioAlert.ClearAlertsEvt += _wiaSalario.ClearAlerts;
             }
         }

        /// <summary>
        /// Evento del componente que se ejecuta cuando se modifica el valor del componente Salario.
        /// </summary>
        public void Salario_OnChange(Decimal newValue)
        {
            _scriptsUser.Empleado.Salario = newValue;
            EmpleadoValidate("Salario", _modelControls.SalarioAlert);
            _scriptsUser.Salario_OnChange();
        }
        #endregion Salario

        #region Correo

        // Este código fue generado por el fichero WoMaskedEditPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoMaskedEdit\WoMaskedEditPartial.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoMaskedEdit<string, App>? _mkdCorreo;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusMkdCorreo()
        {
            if (_mkdCorreo != null)
            {
                _modelControls.Correo.ChangeEnabledEvt += _mkdCorreo.ChangeStatus;
                _modelControls.Correo.ChangeSizeEvt += _mkdCorreo.ChangeFontSize;

                _modelControls.Correo.ChangeControlFontColorEvt += _mkdCorreo.ChangeControlFontColor;
                _modelControls.Correo.ChangeControlFontWeightEvt += _mkdCorreo.ChangeControlFontWeight;
                _modelControls.Correo.ChangeControlFontItalicEvt += _mkdCorreo.ChangeControlFontItalic;
                _modelControls.Correo.ChangeControlFontDecorationEvt += _mkdCorreo.ChangeControlFontDecoration;

                _modelControls.Correo.ChangeBackColorEvt += _mkdCorreo.ChangeBackgroundColor;

                _modelControls.Correo.ActualizarComponente();
                CheckForm();
            }
        }

        /// <summary>
        /// Referencia del contenedor del item.
        /// </summary>
        private WoFormItem? _fliCorreo;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del contenedor a los 
        /// eventos del contenedor a través de la referencia.
        /// </summary>
        /// <param name="status"></param>
        public void SetStatusFliCorreo()
        {
            if (_fliCorreo != null)
            {
                _modelControls.CorreoContainer.ChangeCaptionFontColorEvt += _fliCorreo.ChangeCaptionFontColor;
                _modelControls.CorreoContainer.ChangeCaptionFontWeightEvt += _fliCorreo.ChangeCaptionFontWeight;
                _modelControls.CorreoContainer.ChangeCaptionFontItalicEvt += _fliCorreo.ChangeCaptionFontItalic;
                _modelControls.CorreoContainer.ChangeCaptionFontDecorationEvt += _fliCorreo.ChangeCaptionFontDecoration;
                _modelControls.CorreoContainer.ChangeSizeEvt += _fliCorreo.ChangeFontSize;
            }
        }

        /// <summary>
        /// Referencia de la alerta del item.
        /// </summary>
        private WoInputAlert? _wiaCorreo;

         /// <summary>
         /// Suscribe los controladores de eventos de la vista a los eventos de la alerta a través de la referencia.
         /// </summary>
         public void SetStatusWiaCorreo()
         {
             if (_wiaCorreo != null)
             {
                 _modelControls.CorreoAlert.SetAlertValueEvt += _wiaCorreo.SetAlertValue;
                 _modelControls.CorreoAlert.ClearAlertsEvt += _wiaCorreo.ClearAlerts;
             }
         }

        /// <summary>
        /// Evento del componente que se ejecuta cuando se modifica el valor del componente Correo.
        /// </summary>
        public void Correo_OnChange(string newValue)
        {
            _scriptsUser.Empleado.Correo = newValue;
            EmpleadoValidate("Correo", _modelControls.CorreoAlert);
            _scriptsUser.Correo_OnChange();
        }
        #endregion Correo

        #region Telefono

        // Este código fue generado por el fichero WoMaskedEditPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoMaskedEdit\WoMaskedEditPartial.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoMaskedEdit<string, App>? _mkdTelefono;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusMkdTelefono()
        {
            if (_mkdTelefono != null)
            {
                _modelControls.Telefono.ChangeEnabledEvt += _mkdTelefono.ChangeStatus;
                _modelControls.Telefono.ChangeSizeEvt += _mkdTelefono.ChangeFontSize;

                _modelControls.Telefono.ChangeControlFontColorEvt += _mkdTelefono.ChangeControlFontColor;
                _modelControls.Telefono.ChangeControlFontWeightEvt += _mkdTelefono.ChangeControlFontWeight;
                _modelControls.Telefono.ChangeControlFontItalicEvt += _mkdTelefono.ChangeControlFontItalic;
                _modelControls.Telefono.ChangeControlFontDecorationEvt += _mkdTelefono.ChangeControlFontDecoration;

                _modelControls.Telefono.ChangeBackColorEvt += _mkdTelefono.ChangeBackgroundColor;

                _modelControls.Telefono.ActualizarComponente();
                CheckForm();
            }
        }

        /// <summary>
        /// Referencia del contenedor del item.
        /// </summary>
        private WoFormItem? _fliTelefono;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del contenedor a los 
        /// eventos del contenedor a través de la referencia.
        /// </summary>
        /// <param name="status"></param>
        public void SetStatusFliTelefono()
        {
            if (_fliTelefono != null)
            {
                _modelControls.TelefonoContainer.ChangeCaptionFontColorEvt += _fliTelefono.ChangeCaptionFontColor;
                _modelControls.TelefonoContainer.ChangeCaptionFontWeightEvt += _fliTelefono.ChangeCaptionFontWeight;
                _modelControls.TelefonoContainer.ChangeCaptionFontItalicEvt += _fliTelefono.ChangeCaptionFontItalic;
                _modelControls.TelefonoContainer.ChangeCaptionFontDecorationEvt += _fliTelefono.ChangeCaptionFontDecoration;
                _modelControls.TelefonoContainer.ChangeSizeEvt += _fliTelefono.ChangeFontSize;
            }
        }

        /// <summary>
        /// Referencia de la alerta del item.
        /// </summary>
        private WoInputAlert? _wiaTelefono;

         /// <summary>
         /// Suscribe los controladores de eventos de la vista a los eventos de la alerta a través de la referencia.
         /// </summary>
         public void SetStatusWiaTelefono()
         {
             if (_wiaTelefono != null)
             {
                 _modelControls.TelefonoAlert.SetAlertValueEvt += _wiaTelefono.SetAlertValue;
                 _modelControls.TelefonoAlert.ClearAlertsEvt += _wiaTelefono.ClearAlerts;
             }
         }

        /// <summary>
        /// Evento del componente que se ejecuta cuando se modifica el valor del componente Telefono.
        /// </summary>
        public void Telefono_OnChange(string newValue)
        {
            _scriptsUser.Empleado.Telefono = newValue;
            EmpleadoValidate("Telefono", _modelControls.TelefonoAlert);
            _scriptsUser.Telefono_OnChange();
        }
        #endregion Telefono

        #region TipoDeEmpleadoId

        // Este código fue generado por el fichero WoLookUpEditPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoLookUpEdit\WoLookUpEditPartial.cs.
        // WoWSB por el generador a día 5-10-2023

        #region Item

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoLookupEdit<WoColumnMetaAttribute, WoLabelModelAttribute, TipoDeEmpleado, App>? _lkpTipoDeEmpleadoId;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public async void SetStatusLkpTipoDeEmpleadoId()
        {
            if (_lkpTipoDeEmpleadoId != null)
            {
                _modelControls.TipoDeEmpleadoId.ChangeEnabledEvt += _lkpTipoDeEmpleadoId.ChangeStatus;
                _modelControls.TipoDeEmpleadoId.ChangeSizeEvt += _lkpTipoDeEmpleadoId.ChangeFontSize;

                _modelControls.TipoDeEmpleadoId.ChangeControlFontColorEvt += _lkpTipoDeEmpleadoId.ChangeControlFontColor;
                _modelControls.TipoDeEmpleadoId.ChangeControlFontWeightEvt += _lkpTipoDeEmpleadoId.ChangeControlFontWeight;
                _modelControls.TipoDeEmpleadoId.ChangeControlFontItalicEvt += _lkpTipoDeEmpleadoId.ChangeControlFontItalic;
                _modelControls.TipoDeEmpleadoId.ChangeControlFontDecorationEvt += _lkpTipoDeEmpleadoId.ChangeControlFontDecoration;

                _modelControls.TipoDeEmpleadoId.ChangeBackColorEvt += _lkpTipoDeEmpleadoId.ChangeBackgroundColor;

                _modelControls.TipoDeEmpleadoId.ActualizarComponente();
                CheckForm();
                await lkpTipoDeEmpleadoId_InitializeServices();
            }
        }

        #endregion Item

        #region Contenedor

        /// <summary>
        /// Referencia del contenedor del item.
        /// </summary>
        private WoFormItem? _fliTipoDeEmpleadoId;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del contenedor a los 
        /// eventos del contenedor a través de la referencia.
        /// </summary>
        /// <param name="status"></param>
        public void SetStatusFliTipoDeEmpleadoId()
        {
            if (_fliTipoDeEmpleadoId != null)
            {
                _modelControls.TipoDeEmpleadoIdContainer.ChangeCaptionFontColorEvt += _fliTipoDeEmpleadoId.ChangeCaptionFontColor;
                _modelControls.TipoDeEmpleadoIdContainer.ChangeCaptionFontWeightEvt += _fliTipoDeEmpleadoId.ChangeCaptionFontWeight;
                _modelControls.TipoDeEmpleadoIdContainer.ChangeCaptionFontItalicEvt += _fliTipoDeEmpleadoId.ChangeCaptionFontItalic;
                _modelControls.TipoDeEmpleadoIdContainer.ChangeCaptionFontDecorationEvt += _fliTipoDeEmpleadoId.ChangeCaptionFontDecoration;
                _modelControls.TipoDeEmpleadoIdContainer.ChangeSizeEvt += _fliTipoDeEmpleadoId.ChangeFontSize;
            }
        }

        #endregion Contenedor

        #region Alertas

        /// <summary>
        /// Referencia de la alerta del item.
        /// </summary>
        private WoInputAlert? _wiaTipoDeEmpleadoId;

         /// <summary>
         /// Suscribe los controladores de eventos de la vista a los eventos de la alerta a través de la referencia.
         /// </summary>
         public void SetStatusWiaTipoDeEmpleadoId()
         {
             if (_wiaTipoDeEmpleadoId != null)
             {
                 _modelControls.TipoDeEmpleadoIdAlert.SetAlertValueEvt += _wiaTipoDeEmpleadoId.SetAlertValue;
                 _modelControls.TipoDeEmpleadoIdAlert.ClearAlertsEvt += _wiaTipoDeEmpleadoId.ClearAlerts;
             }
         }
        #endregion Alertas

        #region Data del LookUp

        /// <summary>
        /// Contiene los componentes para pintar la grid dentro del combo.
        /// </summary>
        private IEnumerable<MemberInfo>? _lkpTipoDeEmpleadoColumnsCol;

        /// <summary>
        /// Nombre de la propiedad de id del modelo.
        /// </summary>
        private string _idTipoDeEmpleadoPropertyName = string.Empty;

        /// <summary>
        /// Nombre de la propiedad que servirá de descripción en el lookup
        /// </summary>
        private string _descriptionTipoDeEmpleadoPropertyName = string.Empty;


        /// <summary>
        /// Recupera la instancia de configuración del modelo principal y a través de este recupera la
        /// información para: las columnas que se muestran en el combo, los nombres de la propiedades de
        /// descripción y de id, y la información del filtro del dto para la realización de peticiones.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<(string select, string filter, string orderBy)> LkpTipoDeEmpleadoId_OnInitialize()
        {
            try
            {
                WoLookUpConfigAttribute? woLookUpConfigTipoDeEmpleadoId = typeof(TipoDeEmpleado)
                    .GetCustomAttributes(typeof(WoLookUpConfigAttribute), false)
                    .Cast<WoLookUpConfigAttribute>()
                    .FirstOrDefault();
        
                if (woLookUpConfigTipoDeEmpleadoId != null)
                {
                    _idTipoDeEmpleadoPropertyName = woLookUpConfigTipoDeEmpleadoId.KeyField;
                    _descriptionTipoDeEmpleadoPropertyName = woLookUpConfigTipoDeEmpleadoId.DescriptionField;
        
                    _lkpTipoDeEmpleadoColumnsCol = from Member in typeof(TipoDeEmpleado).GetMembers()
                                                   join SelectMember in woLookUpConfigTipoDeEmpleadoId.Select.Split(",").ToList()
                                                   on Member.Name equals SelectMember
                                                   select Member;

                    return (woLookUpConfigTipoDeEmpleadoId.Select, woLookUpConfigTipoDeEmpleadoId.Filter, woLookUpConfigTipoDeEmpleadoId.OrderBy);
                }
                else
                {
                    throw new Exception("_woLookUpConfigTipoDeEmpleadoId es nulo");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion Data del LookUp
        #region Servicios

        /// <summary>
        /// Lista de los datos que mostrara el combo interno.
        /// </summary>
        private IEnumerable<TipoDeEmpleado>? _TipoDeEmpleadoCol;

        /// <summary>
        /// Servicio del lookup de consulta de los datos.
        /// </summary>
        private WoLookupService<TipoDeEmpleado, TipoDeEmpleadoGet, TipoDeEmpleadoList>? _lkpServiceTipoDeEmpleadoId;

        /// <summary>
        /// Tupla con la data del select, filter y orderby del dto.
        /// </summary>
        private (string select, string filter, string orderBy)? _dtoSettingsTipoDeEmpleadoId;



        /// <summary>
        /// Inicializa los servicios del componente.
        /// Detonar en el Set Status del componente.
        /// </summary>
        /// <returns></returns>
        private async Task lkpTipoDeEmpleadoId_InitializeServices()
        {
            _dtoSettingsTipoDeEmpleadoId = await LkpTipoDeEmpleadoId_OnInitialize();
            _lkpServiceTipoDeEmpleadoId = new WoLookupService<TipoDeEmpleado, TipoDeEmpleadoGet, TipoDeEmpleadoList>(Client, _dtoSettingsTipoDeEmpleadoId);
        }

        /// <summary>
        /// Actualiza la data de la lista.
        /// Va al servicio y realiza una consulta en función de la data del dto recuperada al
        /// inicial el componente.
        /// </summary>
        /// <returns></returns>
        public async Task TipoDeEmpleadoId_UpdateData()
        {
            if (_lkpServiceTipoDeEmpleadoId != null)
            {
                _TipoDeEmpleadoCol = await _lkpServiceTipoDeEmpleadoId.GetDataList();
            }
        }

        #endregion Servicios
        #region Estados

        /// <summary>
        /// Cambia el componente a modo de navegación,
        /// solo con los datos del modelo.
        /// </summary>
        private void LkpTipoDeEmpleadoId_NavigationMode()
        {
            TipoDeEmpleado simpleData = new TipoDeEmpleado();
            simpleData.Id = _scriptsUser.Empleado.TipoDeEmpleadoId;
        
            simpleData.Nombre = _scriptsUser.Empleado.__TipoDeEmpleadoId;
        
            _TipoDeEmpleadoCol = new List<TipoDeEmpleado>() { simpleData };
        }
        #endregion Estados



        #region Cambio de valor

        /// <summary>
        /// Evento del componente que se ejecuta cuando se modifica el valor del componente TipoDeEmpleadoId.
        /// </summary>
        public void TipoDeEmpleadoId_OnChange(string newValue)
        {
            _scriptsUser.Empleado.TipoDeEmpleadoId = newValue;

            _scriptsUser.TipoDeEmpleadoId_OnChange();

            var searchResult = _TipoDeEmpleadoCol?.Where(x => x.Id == newValue).FirstOrDefault();

            PropertyInfo? propertyDescription = typeof(TipoDeEmpleado).GetProperty(_descriptionTipoDeEmpleadoPropertyName);

            if (searchResult != null)
            {
                string? description = propertyDescription?.GetValue(searchResult)?.ToString();
                _scriptsUser.Empleado.__TipoDeEmpleadoId = description;
        
                _modelControls.TipoDeEmpleadoIdAlert.LimpiarAlertas();
               EmpleadoValidate("TipoDeEmpleadoId", _modelControls.TipoDeEmpleadoIdAlert);
            }
            else
            {
                _scriptsUser.Empleado.TipoDeEmpleadoId = string.Empty;
                _scriptsUser.Empleado.__TipoDeEmpleadoId = string.Empty;
        
                EmpleadoValidate("TipoDeEmpleadoId", _modelControls.TipoDeEmpleadoIdAlert);
                _modelControls.TipoDeEmpleadoIdAlert.AgregarAlerta("No se encontró el registro");
            }
        }

        #endregion Cambio de valor
        #endregion TipoDeEmpleadoId

        #region WoState

        // Este código fue generado por el fichero WoComboEnumEditPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoComboEnumEdit\WoComboEnumEditPartial.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoComboEnumEdit<eEmpleado_WoState, App>? _cmbWoState;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusCmbWoState()
        {
            if (_cmbWoState != null)
            {
                _modelControls.WoState.ChangeEnabledEvt += _cmbWoState.ChangeStatus;
                _modelControls.WoState.ChangeSizeEvt += _cmbWoState.ChangeFontSize;

                _modelControls.WoState.ChangeControlFontColorEvt += _cmbWoState.ChangeControlFontColor;
                _modelControls.WoState.ChangeControlFontWeightEvt += _cmbWoState.ChangeControlFontWeight;
                _modelControls.WoState.ChangeControlFontItalicEvt += _cmbWoState.ChangeControlFontItalic;
                _modelControls.WoState.ChangeControlFontDecorationEvt += _cmbWoState.ChangeControlFontDecoration;

                _modelControls.WoState.ChangeBackColorEvt += _cmbWoState.ChangeBackgroundColor;

                _modelControls.WoState.ActualizarComponente();
                CheckForm();
            }
        }

        /// <summary>
        /// Referencia del contenedor del item.
        /// </summary>
        private WoFormItem? _fliWoState;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del contenedor a los 
        /// eventos del contenedor a través de la referencia.
        /// </summary>
        /// <param name="status"></param>
        public void SetStatusFliWoState()
        {
            if (_fliWoState != null)
            {
                _modelControls.WoStateContainer.ChangeCaptionFontColorEvt += _fliWoState.ChangeCaptionFontColor;
                _modelControls.WoStateContainer.ChangeCaptionFontWeightEvt += _fliWoState.ChangeCaptionFontWeight;
                _modelControls.WoStateContainer.ChangeCaptionFontItalicEvt += _fliWoState.ChangeCaptionFontItalic;
                _modelControls.WoStateContainer.ChangeCaptionFontDecorationEvt += _fliWoState.ChangeCaptionFontDecoration;
                _modelControls.WoStateContainer.ChangeSizeEvt += _fliWoState.ChangeFontSize;
            }
        }

        /// <summary>
        /// Referencia de la alerta del item.
        /// </summary>
        private WoInputAlert? _wiaWoState;

         /// <summary>
         /// Suscribe los controladores de eventos de la vista a los eventos de la alerta a través de la referencia.
         /// </summary>
         public void SetStatusWiaWoState()
         {
             if (_wiaWoState != null)
             {
                 _modelControls.WoStateAlert.SetAlertValueEvt += _wiaWoState.SetAlertValue;
                 _modelControls.WoStateAlert.ClearAlertsEvt += _wiaWoState.ClearAlerts;
             }
         }

        /// <summary>
        /// Evento del componente que se ejecuta cuando se modifica el valor del componente WoState.
        /// </summary>
        public void WoState_OnChange(eEmpleado_WoState newValue)
        {
            _scriptsUser.Empleado.WoState = newValue;
            EmpleadoValidate("WoState", _modelControls.WoStateAlert);
            _scriptsUser.WoState_OnChange();
        }
        #endregion WoState

        #region CreatedDate

        // Este código fue generado por el fichero WoDateEditPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoDateEdit\WoDateEditPartial.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoDateEdit<DateTime,App>? _dteCreatedDate;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusDteCreatedDate()
        {
            if (_dteCreatedDate != null)
            {
                _modelControls.CreatedDate.ChangeEnabledEvt += _dteCreatedDate.ChangeStatus;
                _modelControls.CreatedDate.ChangeSizeEvt += _dteCreatedDate.ChangeFontSize;

                _modelControls.CreatedDate.ChangeControlFontColorEvt += _dteCreatedDate.ChangeControlFontColor;
                _modelControls.CreatedDate.ChangeControlFontWeightEvt += _dteCreatedDate.ChangeControlFontWeight;
                _modelControls.CreatedDate.ChangeControlFontItalicEvt += _dteCreatedDate.ChangeControlFontItalic;
                _modelControls.CreatedDate.ChangeControlFontDecorationEvt += _dteCreatedDate.ChangeControlFontDecoration;

                _modelControls.CreatedDate.ChangeBackColorEvt += _dteCreatedDate.ChangeBackgroundColor;

                _modelControls.CreatedDate.ActualizarComponente();
                CheckForm();
            }
        }

        /// <summary>
        /// Referencia del contenedor del item.
        /// </summary>
        private WoFormItem? _fliCreatedDate;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del contenedor a los 
        /// eventos del contenedor a través de la referencia.
        /// </summary>
        /// <param name="status"></param>
        public void SetStatusFliCreatedDate()
        {
            if (_fliCreatedDate != null)
            {
                _modelControls.CreatedDateContainer.ChangeCaptionFontColorEvt += _fliCreatedDate.ChangeCaptionFontColor;
                _modelControls.CreatedDateContainer.ChangeCaptionFontWeightEvt += _fliCreatedDate.ChangeCaptionFontWeight;
                _modelControls.CreatedDateContainer.ChangeCaptionFontItalicEvt += _fliCreatedDate.ChangeCaptionFontItalic;
                _modelControls.CreatedDateContainer.ChangeCaptionFontDecorationEvt += _fliCreatedDate.ChangeCaptionFontDecoration;
                _modelControls.CreatedDateContainer.ChangeSizeEvt += _fliCreatedDate.ChangeFontSize;
            }
        }

        /// <summary>
        /// Referencia de la alerta del item.
        /// </summary>
        private WoInputAlert? _wiaCreatedDate;

         /// <summary>
         /// Suscribe los controladores de eventos de la vista a los eventos de la alerta a través de la referencia.
         /// </summary>
         public void SetStatusWiaCreatedDate()
         {
             if (_wiaCreatedDate != null)
             {
                 _modelControls.CreatedDateAlert.SetAlertValueEvt += _wiaCreatedDate.SetAlertValue;
                 _modelControls.CreatedDateAlert.ClearAlertsEvt += _wiaCreatedDate.ClearAlerts;
             }
         }

        /// <summary>
        /// Evento del componente que se ejecuta cuando se modifica el valor del componente CreatedDate.
        /// </summary>
        public void CreatedDate_OnChange(DateTime newValue)
        {
            _scriptsUser.Empleado.CreatedDate = newValue;
            EmpleadoValidate("CreatedDate", _modelControls.CreatedDateAlert);
            _scriptsUser.CreatedDate_OnChange();
        }
        #endregion CreatedDate

        #region CreatedBy

        // Este código fue generado por el fichero WoTextEditPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditPartial.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoTextEdit<App>? _txtCreatedBy;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusTxtCreatedBy()
        {
            if (_txtCreatedBy != null)
            {
                _modelControls.CreatedBy.ChangeEnabledEvt += _txtCreatedBy.ChangeStatus;
                _modelControls.CreatedBy.ChangeSizeEvt += _txtCreatedBy.ChangeFontSize;
        
                _modelControls.CreatedBy.ChangeControlFontColorEvt += _txtCreatedBy.ChangeControlFontColor;
                _modelControls.CreatedBy.ChangeControlFontWeightEvt += _txtCreatedBy.ChangeControlFontWeight;
                _modelControls.CreatedBy.ChangeControlFontItalicEvt += _txtCreatedBy.ChangeControlFontItalic;
                _modelControls.CreatedBy.ChangeControlFontDecorationEvt += _txtCreatedBy.ChangeControlFontDecoration;
        
                _modelControls.CreatedBy.ChangeBackColorEvt += _txtCreatedBy.ChangeBackgroundColor;
        
                _modelControls.CreatedBy.ActualizarComponente();
                CheckForm();
            }
        }

        /// <summary>
        /// Referencia del contenedor del item.
        /// </summary>
        private WoFormItem? _fliCreatedBy;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del contenedor a los 
        /// eventos del contenedor a través de la referencia.
        /// </summary>
        /// <param name="status"></param>
        public void SetStatusFliCreatedBy()
        {
            if (_fliCreatedBy != null)
            {
                _modelControls.CreatedByContainer.ChangeCaptionFontColorEvt += _fliCreatedBy.ChangeCaptionFontColor;
                _modelControls.CreatedByContainer.ChangeCaptionFontWeightEvt += _fliCreatedBy.ChangeCaptionFontWeight;
                _modelControls.CreatedByContainer.ChangeCaptionFontItalicEvt += _fliCreatedBy.ChangeCaptionFontItalic;
                _modelControls.CreatedByContainer.ChangeCaptionFontDecorationEvt += _fliCreatedBy.ChangeCaptionFontDecoration;
                _modelControls.CreatedByContainer.ChangeSizeEvt += _fliCreatedBy.ChangeFontSize;
            }
        }

        /// <summary>
        /// Referencia de la alerta del item.
        /// </summary>
        private WoInputAlert? _wiaCreatedBy;

         /// <summary>
         /// Suscribe los controladores de eventos de la vista a los eventos de la alerta a través de la referencia.
         /// </summary>
         public void SetStatusWiaCreatedBy()
         {
             if (_wiaCreatedBy != null)
             {
                 _modelControls.CreatedByAlert.SetAlertValueEvt += _wiaCreatedBy.SetAlertValue;
                 _modelControls.CreatedByAlert.ClearAlertsEvt += _wiaCreatedBy.ClearAlerts;
             }
         }

        /// <summary>
        /// Evento del componente que se ejecuta cuando se modifica el valor del componente CreatedBy.
        /// </summary>
        public void CreatedBy_OnChange(string newValue)
        {
            _scriptsUser.Empleado.CreatedBy = newValue;
            EmpleadoValidate("CreatedBy", _modelControls.CreatedByAlert);
            _scriptsUser.CreatedBy_OnChange();
        }

        #endregion CreatedBy

        #region ModifiedDate

        // Este código fue generado por el fichero WoDateEditPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoDateEdit\WoDateEditPartial.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoDateEdit<DateTime,App>? _dteModifiedDate;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusDteModifiedDate()
        {
            if (_dteModifiedDate != null)
            {
                _modelControls.ModifiedDate.ChangeEnabledEvt += _dteModifiedDate.ChangeStatus;
                _modelControls.ModifiedDate.ChangeSizeEvt += _dteModifiedDate.ChangeFontSize;

                _modelControls.ModifiedDate.ChangeControlFontColorEvt += _dteModifiedDate.ChangeControlFontColor;
                _modelControls.ModifiedDate.ChangeControlFontWeightEvt += _dteModifiedDate.ChangeControlFontWeight;
                _modelControls.ModifiedDate.ChangeControlFontItalicEvt += _dteModifiedDate.ChangeControlFontItalic;
                _modelControls.ModifiedDate.ChangeControlFontDecorationEvt += _dteModifiedDate.ChangeControlFontDecoration;

                _modelControls.ModifiedDate.ChangeBackColorEvt += _dteModifiedDate.ChangeBackgroundColor;

                _modelControls.ModifiedDate.ActualizarComponente();
                CheckForm();
            }
        }

        /// <summary>
        /// Referencia del contenedor del item.
        /// </summary>
        private WoFormItem? _fliModifiedDate;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del contenedor a los 
        /// eventos del contenedor a través de la referencia.
        /// </summary>
        /// <param name="status"></param>
        public void SetStatusFliModifiedDate()
        {
            if (_fliModifiedDate != null)
            {
                _modelControls.ModifiedDateContainer.ChangeCaptionFontColorEvt += _fliModifiedDate.ChangeCaptionFontColor;
                _modelControls.ModifiedDateContainer.ChangeCaptionFontWeightEvt += _fliModifiedDate.ChangeCaptionFontWeight;
                _modelControls.ModifiedDateContainer.ChangeCaptionFontItalicEvt += _fliModifiedDate.ChangeCaptionFontItalic;
                _modelControls.ModifiedDateContainer.ChangeCaptionFontDecorationEvt += _fliModifiedDate.ChangeCaptionFontDecoration;
                _modelControls.ModifiedDateContainer.ChangeSizeEvt += _fliModifiedDate.ChangeFontSize;
            }
        }

        /// <summary>
        /// Referencia de la alerta del item.
        /// </summary>
        private WoInputAlert? _wiaModifiedDate;

         /// <summary>
         /// Suscribe los controladores de eventos de la vista a los eventos de la alerta a través de la referencia.
         /// </summary>
         public void SetStatusWiaModifiedDate()
         {
             if (_wiaModifiedDate != null)
             {
                 _modelControls.ModifiedDateAlert.SetAlertValueEvt += _wiaModifiedDate.SetAlertValue;
                 _modelControls.ModifiedDateAlert.ClearAlertsEvt += _wiaModifiedDate.ClearAlerts;
             }
         }

        /// <summary>
        /// Evento del componente que se ejecuta cuando se modifica el valor del componente ModifiedDate.
        /// </summary>
        public void ModifiedDate_OnChange(DateTime newValue)
        {
            _scriptsUser.Empleado.ModifiedDate = newValue;
            EmpleadoValidate("ModifiedDate", _modelControls.ModifiedDateAlert);
            _scriptsUser.ModifiedDate_OnChange();
        }
        #endregion ModifiedDate

        #region ModifiedBy

        // Este código fue generado por el fichero WoTextEditPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditPartial.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoTextEdit<App>? _txtModifiedBy;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusTxtModifiedBy()
        {
            if (_txtModifiedBy != null)
            {
                _modelControls.ModifiedBy.ChangeEnabledEvt += _txtModifiedBy.ChangeStatus;
                _modelControls.ModifiedBy.ChangeSizeEvt += _txtModifiedBy.ChangeFontSize;
        
                _modelControls.ModifiedBy.ChangeControlFontColorEvt += _txtModifiedBy.ChangeControlFontColor;
                _modelControls.ModifiedBy.ChangeControlFontWeightEvt += _txtModifiedBy.ChangeControlFontWeight;
                _modelControls.ModifiedBy.ChangeControlFontItalicEvt += _txtModifiedBy.ChangeControlFontItalic;
                _modelControls.ModifiedBy.ChangeControlFontDecorationEvt += _txtModifiedBy.ChangeControlFontDecoration;
        
                _modelControls.ModifiedBy.ChangeBackColorEvt += _txtModifiedBy.ChangeBackgroundColor;
        
                _modelControls.ModifiedBy.ActualizarComponente();
                CheckForm();
            }
        }

        /// <summary>
        /// Referencia del contenedor del item.
        /// </summary>
        private WoFormItem? _fliModifiedBy;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del contenedor a los 
        /// eventos del contenedor a través de la referencia.
        /// </summary>
        /// <param name="status"></param>
        public void SetStatusFliModifiedBy()
        {
            if (_fliModifiedBy != null)
            {
                _modelControls.ModifiedByContainer.ChangeCaptionFontColorEvt += _fliModifiedBy.ChangeCaptionFontColor;
                _modelControls.ModifiedByContainer.ChangeCaptionFontWeightEvt += _fliModifiedBy.ChangeCaptionFontWeight;
                _modelControls.ModifiedByContainer.ChangeCaptionFontItalicEvt += _fliModifiedBy.ChangeCaptionFontItalic;
                _modelControls.ModifiedByContainer.ChangeCaptionFontDecorationEvt += _fliModifiedBy.ChangeCaptionFontDecoration;
                _modelControls.ModifiedByContainer.ChangeSizeEvt += _fliModifiedBy.ChangeFontSize;
            }
        }

        /// <summary>
        /// Referencia de la alerta del item.
        /// </summary>
        private WoInputAlert? _wiaModifiedBy;

         /// <summary>
         /// Suscribe los controladores de eventos de la vista a los eventos de la alerta a través de la referencia.
         /// </summary>
         public void SetStatusWiaModifiedBy()
         {
             if (_wiaModifiedBy != null)
             {
                 _modelControls.ModifiedByAlert.SetAlertValueEvt += _wiaModifiedBy.SetAlertValue;
                 _modelControls.ModifiedByAlert.ClearAlertsEvt += _wiaModifiedBy.ClearAlerts;
             }
         }

        /// <summary>
        /// Evento del componente que se ejecuta cuando se modifica el valor del componente ModifiedBy.
        /// </summary>
        public void ModifiedBy_OnChange(string newValue)
        {
            _scriptsUser.Empleado.ModifiedBy = newValue;
            EmpleadoValidate("ModifiedBy", _modelControls.ModifiedByAlert);
            _scriptsUser.ModifiedBy_OnChange();
        }

        #endregion ModifiedBy

        #region SuspendDate

        // Este código fue generado por el fichero WoDateEditPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoDateEdit\WoDateEditPartial.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoDateEdit<DateTime?,App>? _dteSuspendDate;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusDteSuspendDate()
        {
            if (_dteSuspendDate != null)
            {
                _modelControls.SuspendDate.ChangeEnabledEvt += _dteSuspendDate.ChangeStatus;
                _modelControls.SuspendDate.ChangeSizeEvt += _dteSuspendDate.ChangeFontSize;

                _modelControls.SuspendDate.ChangeControlFontColorEvt += _dteSuspendDate.ChangeControlFontColor;
                _modelControls.SuspendDate.ChangeControlFontWeightEvt += _dteSuspendDate.ChangeControlFontWeight;
                _modelControls.SuspendDate.ChangeControlFontItalicEvt += _dteSuspendDate.ChangeControlFontItalic;
                _modelControls.SuspendDate.ChangeControlFontDecorationEvt += _dteSuspendDate.ChangeControlFontDecoration;

                _modelControls.SuspendDate.ChangeBackColorEvt += _dteSuspendDate.ChangeBackgroundColor;

                _modelControls.SuspendDate.ActualizarComponente();
                CheckForm();
            }
        }

        /// <summary>
        /// Referencia del contenedor del item.
        /// </summary>
        private WoFormItem? _fliSuspendDate;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del contenedor a los 
        /// eventos del contenedor a través de la referencia.
        /// </summary>
        /// <param name="status"></param>
        public void SetStatusFliSuspendDate()
        {
            if (_fliSuspendDate != null)
            {
                _modelControls.SuspendDateContainer.ChangeCaptionFontColorEvt += _fliSuspendDate.ChangeCaptionFontColor;
                _modelControls.SuspendDateContainer.ChangeCaptionFontWeightEvt += _fliSuspendDate.ChangeCaptionFontWeight;
                _modelControls.SuspendDateContainer.ChangeCaptionFontItalicEvt += _fliSuspendDate.ChangeCaptionFontItalic;
                _modelControls.SuspendDateContainer.ChangeCaptionFontDecorationEvt += _fliSuspendDate.ChangeCaptionFontDecoration;
                _modelControls.SuspendDateContainer.ChangeSizeEvt += _fliSuspendDate.ChangeFontSize;
            }
        }

        /// <summary>
        /// Referencia de la alerta del item.
        /// </summary>
        private WoInputAlert? _wiaSuspendDate;

         /// <summary>
         /// Suscribe los controladores de eventos de la vista a los eventos de la alerta a través de la referencia.
         /// </summary>
         public void SetStatusWiaSuspendDate()
         {
             if (_wiaSuspendDate != null)
             {
                 _modelControls.SuspendDateAlert.SetAlertValueEvt += _wiaSuspendDate.SetAlertValue;
                 _modelControls.SuspendDateAlert.ClearAlertsEvt += _wiaSuspendDate.ClearAlerts;
             }
         }

        /// <summary>
        /// Evento del componente que se ejecuta cuando se modifica el valor del componente SuspendDate.
        /// </summary>
        public void SuspendDate_OnChange(DateTime? newValue)
        {
            _scriptsUser.Empleado.SuspendDate = newValue;
            EmpleadoValidate("SuspendDate", _modelControls.SuspendDateAlert);
            _scriptsUser.SuspendDate_OnChange();
        }
        #endregion SuspendDate

        #region SuspendBy

        // Este código fue generado por el fichero WoTextEditPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditPartial.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoTextEdit<App>? _txtSuspendBy;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusTxtSuspendBy()
        {
            if (_txtSuspendBy != null)
            {
                _modelControls.SuspendBy.ChangeEnabledEvt += _txtSuspendBy.ChangeStatus;
                _modelControls.SuspendBy.ChangeSizeEvt += _txtSuspendBy.ChangeFontSize;
        
                _modelControls.SuspendBy.ChangeControlFontColorEvt += _txtSuspendBy.ChangeControlFontColor;
                _modelControls.SuspendBy.ChangeControlFontWeightEvt += _txtSuspendBy.ChangeControlFontWeight;
                _modelControls.SuspendBy.ChangeControlFontItalicEvt += _txtSuspendBy.ChangeControlFontItalic;
                _modelControls.SuspendBy.ChangeControlFontDecorationEvt += _txtSuspendBy.ChangeControlFontDecoration;
        
                _modelControls.SuspendBy.ChangeBackColorEvt += _txtSuspendBy.ChangeBackgroundColor;
        
                _modelControls.SuspendBy.ActualizarComponente();
                CheckForm();
            }
        }

        /// <summary>
        /// Referencia del contenedor del item.
        /// </summary>
        private WoFormItem? _fliSuspendBy;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del contenedor a los 
        /// eventos del contenedor a través de la referencia.
        /// </summary>
        /// <param name="status"></param>
        public void SetStatusFliSuspendBy()
        {
            if (_fliSuspendBy != null)
            {
                _modelControls.SuspendByContainer.ChangeCaptionFontColorEvt += _fliSuspendBy.ChangeCaptionFontColor;
                _modelControls.SuspendByContainer.ChangeCaptionFontWeightEvt += _fliSuspendBy.ChangeCaptionFontWeight;
                _modelControls.SuspendByContainer.ChangeCaptionFontItalicEvt += _fliSuspendBy.ChangeCaptionFontItalic;
                _modelControls.SuspendByContainer.ChangeCaptionFontDecorationEvt += _fliSuspendBy.ChangeCaptionFontDecoration;
                _modelControls.SuspendByContainer.ChangeSizeEvt += _fliSuspendBy.ChangeFontSize;
            }
        }

        /// <summary>
        /// Referencia de la alerta del item.
        /// </summary>
        private WoInputAlert? _wiaSuspendBy;

         /// <summary>
         /// Suscribe los controladores de eventos de la vista a los eventos de la alerta a través de la referencia.
         /// </summary>
         public void SetStatusWiaSuspendBy()
         {
             if (_wiaSuspendBy != null)
             {
                 _modelControls.SuspendByAlert.SetAlertValueEvt += _wiaSuspendBy.SetAlertValue;
                 _modelControls.SuspendByAlert.ClearAlertsEvt += _wiaSuspendBy.ClearAlerts;
             }
         }

        /// <summary>
        /// Evento del componente que se ejecuta cuando se modifica el valor del componente SuspendBy.
        /// </summary>
        public void SuspendBy_OnChange(string? newValue)
        {
            _scriptsUser.Empleado.SuspendBy = newValue;
            EmpleadoValidate("SuspendBy", _modelControls.SuspendByAlert);
            _scriptsUser.SuspendBy_OnChange();
        }

        #endregion SuspendBy

        #region SuspendInfo

        // Este código fue generado por el fichero WoTextEditPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditPartial.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoTextEdit<App>? _txtSuspendInfo;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusTxtSuspendInfo()
        {
            if (_txtSuspendInfo != null)
            {
                _modelControls.SuspendInfo.ChangeEnabledEvt += _txtSuspendInfo.ChangeStatus;
                _modelControls.SuspendInfo.ChangeSizeEvt += _txtSuspendInfo.ChangeFontSize;
        
                _modelControls.SuspendInfo.ChangeControlFontColorEvt += _txtSuspendInfo.ChangeControlFontColor;
                _modelControls.SuspendInfo.ChangeControlFontWeightEvt += _txtSuspendInfo.ChangeControlFontWeight;
                _modelControls.SuspendInfo.ChangeControlFontItalicEvt += _txtSuspendInfo.ChangeControlFontItalic;
                _modelControls.SuspendInfo.ChangeControlFontDecorationEvt += _txtSuspendInfo.ChangeControlFontDecoration;
        
                _modelControls.SuspendInfo.ChangeBackColorEvt += _txtSuspendInfo.ChangeBackgroundColor;
        
                _modelControls.SuspendInfo.ActualizarComponente();
                CheckForm();
            }
        }

        /// <summary>
        /// Referencia del contenedor del item.
        /// </summary>
        private WoFormItem? _fliSuspendInfo;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del contenedor a los 
        /// eventos del contenedor a través de la referencia.
        /// </summary>
        /// <param name="status"></param>
        public void SetStatusFliSuspendInfo()
        {
            if (_fliSuspendInfo != null)
            {
                _modelControls.SuspendInfoContainer.ChangeCaptionFontColorEvt += _fliSuspendInfo.ChangeCaptionFontColor;
                _modelControls.SuspendInfoContainer.ChangeCaptionFontWeightEvt += _fliSuspendInfo.ChangeCaptionFontWeight;
                _modelControls.SuspendInfoContainer.ChangeCaptionFontItalicEvt += _fliSuspendInfo.ChangeCaptionFontItalic;
                _modelControls.SuspendInfoContainer.ChangeCaptionFontDecorationEvt += _fliSuspendInfo.ChangeCaptionFontDecoration;
                _modelControls.SuspendInfoContainer.ChangeSizeEvt += _fliSuspendInfo.ChangeFontSize;
            }
        }

        /// <summary>
        /// Referencia de la alerta del item.
        /// </summary>
        private WoInputAlert? _wiaSuspendInfo;

         /// <summary>
         /// Suscribe los controladores de eventos de la vista a los eventos de la alerta a través de la referencia.
         /// </summary>
         public void SetStatusWiaSuspendInfo()
         {
             if (_wiaSuspendInfo != null)
             {
                 _modelControls.SuspendInfoAlert.SetAlertValueEvt += _wiaSuspendInfo.SetAlertValue;
                 _modelControls.SuspendInfoAlert.ClearAlertsEvt += _wiaSuspendInfo.ClearAlerts;
             }
         }

        /// <summary>
        /// Evento del componente que se ejecuta cuando se modifica el valor del componente SuspendInfo.
        /// </summary>
        public void SuspendInfo_OnChange(string? newValue)
        {
            _scriptsUser.Empleado.SuspendInfo = newValue;
            EmpleadoValidate("SuspendInfo", _modelControls.SuspendInfoAlert);
            _scriptsUser.SuspendInfo_OnChange();
        }

        #endregion SuspendInfo

        #region DeletedDate

        // Este código fue generado por el fichero WoDateEditPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoDateEdit\WoDateEditPartial.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoDateEdit<DateTime?,App>? _dteDeletedDate;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusDteDeletedDate()
        {
            if (_dteDeletedDate != null)
            {
                _modelControls.DeletedDate.ChangeEnabledEvt += _dteDeletedDate.ChangeStatus;
                _modelControls.DeletedDate.ChangeSizeEvt += _dteDeletedDate.ChangeFontSize;

                _modelControls.DeletedDate.ChangeControlFontColorEvt += _dteDeletedDate.ChangeControlFontColor;
                _modelControls.DeletedDate.ChangeControlFontWeightEvt += _dteDeletedDate.ChangeControlFontWeight;
                _modelControls.DeletedDate.ChangeControlFontItalicEvt += _dteDeletedDate.ChangeControlFontItalic;
                _modelControls.DeletedDate.ChangeControlFontDecorationEvt += _dteDeletedDate.ChangeControlFontDecoration;

                _modelControls.DeletedDate.ChangeBackColorEvt += _dteDeletedDate.ChangeBackgroundColor;

                _modelControls.DeletedDate.ActualizarComponente();
                CheckForm();
            }
        }

        /// <summary>
        /// Referencia del contenedor del item.
        /// </summary>
        private WoFormItem? _fliDeletedDate;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del contenedor a los 
        /// eventos del contenedor a través de la referencia.
        /// </summary>
        /// <param name="status"></param>
        public void SetStatusFliDeletedDate()
        {
            if (_fliDeletedDate != null)
            {
                _modelControls.DeletedDateContainer.ChangeCaptionFontColorEvt += _fliDeletedDate.ChangeCaptionFontColor;
                _modelControls.DeletedDateContainer.ChangeCaptionFontWeightEvt += _fliDeletedDate.ChangeCaptionFontWeight;
                _modelControls.DeletedDateContainer.ChangeCaptionFontItalicEvt += _fliDeletedDate.ChangeCaptionFontItalic;
                _modelControls.DeletedDateContainer.ChangeCaptionFontDecorationEvt += _fliDeletedDate.ChangeCaptionFontDecoration;
                _modelControls.DeletedDateContainer.ChangeSizeEvt += _fliDeletedDate.ChangeFontSize;
            }
        }

        /// <summary>
        /// Referencia de la alerta del item.
        /// </summary>
        private WoInputAlert? _wiaDeletedDate;

         /// <summary>
         /// Suscribe los controladores de eventos de la vista a los eventos de la alerta a través de la referencia.
         /// </summary>
         public void SetStatusWiaDeletedDate()
         {
             if (_wiaDeletedDate != null)
             {
                 _modelControls.DeletedDateAlert.SetAlertValueEvt += _wiaDeletedDate.SetAlertValue;
                 _modelControls.DeletedDateAlert.ClearAlertsEvt += _wiaDeletedDate.ClearAlerts;
             }
         }

        /// <summary>
        /// Evento del componente que se ejecuta cuando se modifica el valor del componente DeletedDate.
        /// </summary>
        public void DeletedDate_OnChange(DateTime? newValue)
        {
            _scriptsUser.Empleado.DeletedDate = newValue;
            EmpleadoValidate("DeletedDate", _modelControls.DeletedDateAlert);
            _scriptsUser.DeletedDate_OnChange();
        }
        #endregion DeletedDate

        #region DeletedBy

        // Este código fue generado por el fichero WoTextEditPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditPartial.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoTextEdit<App>? _txtDeletedBy;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusTxtDeletedBy()
        {
            if (_txtDeletedBy != null)
            {
                _modelControls.DeletedBy.ChangeEnabledEvt += _txtDeletedBy.ChangeStatus;
                _modelControls.DeletedBy.ChangeSizeEvt += _txtDeletedBy.ChangeFontSize;
        
                _modelControls.DeletedBy.ChangeControlFontColorEvt += _txtDeletedBy.ChangeControlFontColor;
                _modelControls.DeletedBy.ChangeControlFontWeightEvt += _txtDeletedBy.ChangeControlFontWeight;
                _modelControls.DeletedBy.ChangeControlFontItalicEvt += _txtDeletedBy.ChangeControlFontItalic;
                _modelControls.DeletedBy.ChangeControlFontDecorationEvt += _txtDeletedBy.ChangeControlFontDecoration;
        
                _modelControls.DeletedBy.ChangeBackColorEvt += _txtDeletedBy.ChangeBackgroundColor;
        
                _modelControls.DeletedBy.ActualizarComponente();
                CheckForm();
            }
        }

        /// <summary>
        /// Referencia del contenedor del item.
        /// </summary>
        private WoFormItem? _fliDeletedBy;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del contenedor a los 
        /// eventos del contenedor a través de la referencia.
        /// </summary>
        /// <param name="status"></param>
        public void SetStatusFliDeletedBy()
        {
            if (_fliDeletedBy != null)
            {
                _modelControls.DeletedByContainer.ChangeCaptionFontColorEvt += _fliDeletedBy.ChangeCaptionFontColor;
                _modelControls.DeletedByContainer.ChangeCaptionFontWeightEvt += _fliDeletedBy.ChangeCaptionFontWeight;
                _modelControls.DeletedByContainer.ChangeCaptionFontItalicEvt += _fliDeletedBy.ChangeCaptionFontItalic;
                _modelControls.DeletedByContainer.ChangeCaptionFontDecorationEvt += _fliDeletedBy.ChangeCaptionFontDecoration;
                _modelControls.DeletedByContainer.ChangeSizeEvt += _fliDeletedBy.ChangeFontSize;
            }
        }

        /// <summary>
        /// Referencia de la alerta del item.
        /// </summary>
        private WoInputAlert? _wiaDeletedBy;

         /// <summary>
         /// Suscribe los controladores de eventos de la vista a los eventos de la alerta a través de la referencia.
         /// </summary>
         public void SetStatusWiaDeletedBy()
         {
             if (_wiaDeletedBy != null)
             {
                 _modelControls.DeletedByAlert.SetAlertValueEvt += _wiaDeletedBy.SetAlertValue;
                 _modelControls.DeletedByAlert.ClearAlertsEvt += _wiaDeletedBy.ClearAlerts;
             }
         }

        /// <summary>
        /// Evento del componente que se ejecuta cuando se modifica el valor del componente DeletedBy.
        /// </summary>
        public void DeletedBy_OnChange(string? newValue)
        {
            _scriptsUser.Empleado.DeletedBy = newValue;
            EmpleadoValidate("DeletedBy", _modelControls.DeletedByAlert);
            _scriptsUser.DeletedBy_OnChange();
        }

        #endregion DeletedBy

        #region DeleteInfo

        // Este código fue generado por el fichero WoTextEditPartial.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditPartial.cs.
        // WoWSB por el generador a día 5-10-2023

        /// <summary>
        /// Referencia que representa el componente.
        /// </summary>
        private WoTextEdit<App>? _txtDeleteInfo;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del componente a los
        /// eventos del componente a través de la referencia.
        /// </summary>
        public void SetStatusTxtDeleteInfo()
        {
            if (_txtDeleteInfo != null)
            {
                _modelControls.DeleteInfo.ChangeEnabledEvt += _txtDeleteInfo.ChangeStatus;
                _modelControls.DeleteInfo.ChangeSizeEvt += _txtDeleteInfo.ChangeFontSize;
        
                _modelControls.DeleteInfo.ChangeControlFontColorEvt += _txtDeleteInfo.ChangeControlFontColor;
                _modelControls.DeleteInfo.ChangeControlFontWeightEvt += _txtDeleteInfo.ChangeControlFontWeight;
                _modelControls.DeleteInfo.ChangeControlFontItalicEvt += _txtDeleteInfo.ChangeControlFontItalic;
                _modelControls.DeleteInfo.ChangeControlFontDecorationEvt += _txtDeleteInfo.ChangeControlFontDecoration;
        
                _modelControls.DeleteInfo.ChangeBackColorEvt += _txtDeleteInfo.ChangeBackgroundColor;
        
                _modelControls.DeleteInfo.ActualizarComponente();
                CheckForm();
            }
        }

        /// <summary>
        /// Referencia del contenedor del item.
        /// </summary>
        private WoFormItem? _fliDeleteInfo;

        /// <summary>
        /// Suscribe los controladores de eventos de la vista del contenedor a los 
        /// eventos del contenedor a través de la referencia.
        /// </summary>
        /// <param name="status"></param>
        public void SetStatusFliDeleteInfo()
        {
            if (_fliDeleteInfo != null)
            {
                _modelControls.DeleteInfoContainer.ChangeCaptionFontColorEvt += _fliDeleteInfo.ChangeCaptionFontColor;
                _modelControls.DeleteInfoContainer.ChangeCaptionFontWeightEvt += _fliDeleteInfo.ChangeCaptionFontWeight;
                _modelControls.DeleteInfoContainer.ChangeCaptionFontItalicEvt += _fliDeleteInfo.ChangeCaptionFontItalic;
                _modelControls.DeleteInfoContainer.ChangeCaptionFontDecorationEvt += _fliDeleteInfo.ChangeCaptionFontDecoration;
                _modelControls.DeleteInfoContainer.ChangeSizeEvt += _fliDeleteInfo.ChangeFontSize;
            }
        }

        /// <summary>
        /// Referencia de la alerta del item.
        /// </summary>
        private WoInputAlert? _wiaDeleteInfo;

         /// <summary>
         /// Suscribe los controladores de eventos de la vista a los eventos de la alerta a través de la referencia.
         /// </summary>
         public void SetStatusWiaDeleteInfo()
         {
             if (_wiaDeleteInfo != null)
             {
                 _modelControls.DeleteInfoAlert.SetAlertValueEvt += _wiaDeleteInfo.SetAlertValue;
                 _modelControls.DeleteInfoAlert.ClearAlertsEvt += _wiaDeleteInfo.ClearAlerts;
             }
         }

        /// <summary>
        /// Evento del componente que se ejecuta cuando se modifica el valor del componente DeleteInfo.
        /// </summary>
        public void DeleteInfo_OnChange(string? newValue)
        {
            _scriptsUser.Empleado.DeleteInfo = newValue;
            EmpleadoValidate("DeleteInfo", _modelControls.DeleteInfoAlert);
            _scriptsUser.DeleteInfo_OnChange();
        }

        #endregion DeleteInfo

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

    }

}


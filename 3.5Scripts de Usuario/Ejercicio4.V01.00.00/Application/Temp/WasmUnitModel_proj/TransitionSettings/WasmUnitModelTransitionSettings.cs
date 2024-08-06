///------------------------------------------------------------------------------------------------------------------
/// Código autogenerado por la template WoTemplateGenericClass en el path WooW.SB\BlazorGenerator\BlazorTemplates\CommonTemplates\TransitionSettings\WoTemplateTransitionSettingsBlazor.tt
/// Genera código consistente con la version de la prueba de concepto a dia 05-10-2023 En Blazor Wasm y Server
/// Este código es auto generado y su modificación puede causar que el código no se comporte como deveria ademas de
/// que se perderan los cambios realizados en el código al momento de la generación.
///------------------------------------------------------------------------------------------------------------------

using WasmUnitModel_proj.ControlModels;

namespace WasmUnitModel_proj.TransitionSettings
{
    
    public class WasmUnitModelTransitionSettings
    {

        #region Constructor

        /// <summary>
        /// Asigna las instancias inyectadas desde el despachador de dependencias de blazor.
        /// <summary>
        public WasmUnitModelTransitionSettings( WasmUnitModelControls _WasmUnitModelControls)
        {
            this._WasmUnitModelControls = _WasmUnitModelControls;
            
        }

        #endregion Constructor

        #region Atributos

        /// <summary>
        /// Inyección de la clase que contiene las vistas de los controles de la vista.
        /// </summary>
        public WasmUnitModelControls _WasmUnitModelControls { get; set; }

        

        #endregion Atributos

        /// <summary>
        /// Detona el método con la configuración de bloqueo de los controles del formulario.
        /// </summary>
        /// <param name="transitionName"></param>
        public void SetBlockSettings(string transition)
        {


            if (transition == "NavigationMode")
            {
                NavigationMode();
            }
            else if (transition == "NavigationModeNoReg")
            {
                NavigationModeNoReg();
            }


            else if (transition == "Nuevo")
            {
                Nuevo();
            }

            else if (transition == "Activar")
            {
                Activar();
            }

            else if (transition == "Suspender")
            {
                Suspender();
            }

            else if (transition == "DarDeBaja")
            {
                DarDeBaja();
            }

            else if (transition == "Modificar")
            {
                Modificar();
            }
        }

        public void NavigationMode()
        {

            _WasmUnitModelControls.Id.EstadoHabilitado(false);


            _WasmUnitModelControls.WoState.EstadoHabilitado(false);


            _WasmUnitModelControls.SuspendInfo.EstadoHabilitado(false);


            _WasmUnitModelControls.SuspendBy.EstadoHabilitado(false);


            _WasmUnitModelControls.SuspendDate.EstadoHabilitado(false);


            _WasmUnitModelControls.DeleteInfo.EstadoHabilitado(false);


            _WasmUnitModelControls.CreatedDate.EstadoHabilitado(false);


            _WasmUnitModelControls.CreatedBy.EstadoHabilitado(false);


            _WasmUnitModelControls.ModifiedDate.EstadoHabilitado(false);


            _WasmUnitModelControls.ModifiedBy.EstadoHabilitado(false);


            _WasmUnitModelControls.DeletedDate.EstadoHabilitado(false);


            _WasmUnitModelControls.DeletedBy.EstadoHabilitado(false);


            _WasmUnitModelControls.Nombre.EstadoHabilitado(false);


            _WasmUnitModelControls.FechaDeNacimiento.EstadoHabilitado(false);


            _WasmUnitModelControls.EstadoCivil.EstadoHabilitado(false);


            _WasmUnitModelControls.Correo.EstadoHabilitado(false);


            _WasmUnitModelControls.Telefono.EstadoHabilitado(false);


            _WasmUnitModelControls.Salario.EstadoHabilitado(false);


            _WasmUnitModelControls.TipoDeEmpleadoId.EstadoHabilitado(false);


            _WasmUnitModelControls.Controles.EstadoNavegacion(true);
            _WasmUnitModelControls.Controles.EstadoBotonesDeDelete(true);
            _WasmUnitModelControls.Controles.EstadoBarraDeTransicion(true);
            _WasmUnitModelControls.Controles.EstadoBotonesDeTransicion(false);
            _WasmUnitModelControls.Compartir.EstadoHabilitado(true);

        }

        private void NavigationModeNoReg()
        {


            _WasmUnitModelControls.Id.EstadoHabilitado(false);


            _WasmUnitModelControls.WoState.EstadoHabilitado(false);


            _WasmUnitModelControls.SuspendInfo.EstadoHabilitado(false);


            _WasmUnitModelControls.SuspendBy.EstadoHabilitado(false);


            _WasmUnitModelControls.SuspendDate.EstadoHabilitado(false);


            _WasmUnitModelControls.DeleteInfo.EstadoHabilitado(false);


            _WasmUnitModelControls.CreatedDate.EstadoHabilitado(false);


            _WasmUnitModelControls.CreatedBy.EstadoHabilitado(false);


            _WasmUnitModelControls.ModifiedDate.EstadoHabilitado(false);


            _WasmUnitModelControls.ModifiedBy.EstadoHabilitado(false);


            _WasmUnitModelControls.DeletedDate.EstadoHabilitado(false);


            _WasmUnitModelControls.DeletedBy.EstadoHabilitado(false);


            _WasmUnitModelControls.Nombre.EstadoHabilitado(false);


            _WasmUnitModelControls.FechaDeNacimiento.EstadoHabilitado(false);


            _WasmUnitModelControls.EstadoCivil.EstadoHabilitado(false);


            _WasmUnitModelControls.Correo.EstadoHabilitado(false);


            _WasmUnitModelControls.Telefono.EstadoHabilitado(false);


            _WasmUnitModelControls.Salario.EstadoHabilitado(false);


            _WasmUnitModelControls.TipoDeEmpleadoId.EstadoHabilitado(false);


            _WasmUnitModelControls.Controles.EstadoNavegacion(false);
            _WasmUnitModelControls.Controles.EstadoBotonesDeDelete(false);
            _WasmUnitModelControls.Controles.EstadoBarraDeTransicion(true);
            _WasmUnitModelControls.Controles.EstadoBotonesDeTransicion(false);
            _WasmUnitModelControls.Compartir.EstadoHabilitado(true);

        }

        public void Nuevo()
        {
            _WasmUnitModelControls.WoState.EstadoHabilitado(false);
            _WasmUnitModelControls.Id.EstadoHabilitado(true);
            _WasmUnitModelControls.Nombre.EstadoHabilitado(true);
            _WasmUnitModelControls.FechaDeNacimiento.EstadoHabilitado(true);
            _WasmUnitModelControls.EstadoCivil.EstadoHabilitado(true);
            _WasmUnitModelControls.Correo.EstadoHabilitado(true);
            _WasmUnitModelControls.Telefono.EstadoHabilitado(true);
            _WasmUnitModelControls.Salario.EstadoHabilitado(true);
            _WasmUnitModelControls.TipoDeEmpleadoId.EstadoHabilitado(true);
            _WasmUnitModelControls.SuspendInfo.EstadoHabilitado(false);
            _WasmUnitModelControls.SuspendBy.EstadoHabilitado(false);
            _WasmUnitModelControls.SuspendDate.EstadoHabilitado(false);
            _WasmUnitModelControls.DeleteInfo.EstadoHabilitado(false);
            _WasmUnitModelControls.CreatedDate.EstadoHabilitado(false);
            _WasmUnitModelControls.CreatedBy.EstadoHabilitado(false);
            _WasmUnitModelControls.ModifiedDate.EstadoHabilitado(false);
            _WasmUnitModelControls.ModifiedBy.EstadoHabilitado(false);
            _WasmUnitModelControls.DeletedDate.EstadoHabilitado(false);
            _WasmUnitModelControls.DeletedBy.EstadoHabilitado(false);

            _WasmUnitModelControls.Controles.EstadoNavegacion(false);
            _WasmUnitModelControls.Controles.EstadoBotonesDeDelete(false);
            _WasmUnitModelControls.Controles.EstadoBarraDeTransicion(false);
            _WasmUnitModelControls.Controles.EstadoBotonesDeTransicion(true);
            _WasmUnitModelControls.Compartir.EstadoHabilitado(false);
        }


        public void Activar()
        {
            _WasmUnitModelControls.Id.EstadoHabilitado(false);
            _WasmUnitModelControls.WoState.EstadoHabilitado(false);
            _WasmUnitModelControls.SuspendInfo.EstadoHabilitado(false);
            _WasmUnitModelControls.SuspendBy.EstadoHabilitado(false);
            _WasmUnitModelControls.SuspendDate.EstadoHabilitado(false);
            _WasmUnitModelControls.DeleteInfo.EstadoHabilitado(false);
            _WasmUnitModelControls.CreatedDate.EstadoHabilitado(false);
            _WasmUnitModelControls.CreatedBy.EstadoHabilitado(false);
            _WasmUnitModelControls.ModifiedDate.EstadoHabilitado(false);
            _WasmUnitModelControls.ModifiedBy.EstadoHabilitado(false);
            _WasmUnitModelControls.DeletedDate.EstadoHabilitado(false);
            _WasmUnitModelControls.DeletedBy.EstadoHabilitado(false);
            _WasmUnitModelControls.Nombre.EstadoHabilitado(false);
            _WasmUnitModelControls.FechaDeNacimiento.EstadoHabilitado(false);
            _WasmUnitModelControls.EstadoCivil.EstadoHabilitado(false);
            _WasmUnitModelControls.Correo.EstadoHabilitado(false);
            _WasmUnitModelControls.Telefono.EstadoHabilitado(false);
            _WasmUnitModelControls.Salario.EstadoHabilitado(false);
            _WasmUnitModelControls.TipoDeEmpleadoId.EstadoHabilitado(false);

            _WasmUnitModelControls.Controles.EstadoNavegacion(false);
            _WasmUnitModelControls.Controles.EstadoBotonesDeDelete(false);
            _WasmUnitModelControls.Controles.EstadoBarraDeTransicion(false);
            _WasmUnitModelControls.Controles.EstadoBotonesDeTransicion(true);
            _WasmUnitModelControls.Compartir.EstadoHabilitado(false);
        }


        public void Suspender()
        {
            _WasmUnitModelControls.Id.EstadoHabilitado(false);
            _WasmUnitModelControls.WoState.EstadoHabilitado(false);
            _WasmUnitModelControls.SuspendInfo.EstadoHabilitado(true);
            _WasmUnitModelControls.SuspendBy.EstadoHabilitado(false);
            _WasmUnitModelControls.SuspendDate.EstadoHabilitado(false);
            _WasmUnitModelControls.DeleteInfo.EstadoHabilitado(false);
            _WasmUnitModelControls.CreatedDate.EstadoHabilitado(false);
            _WasmUnitModelControls.CreatedBy.EstadoHabilitado(false);
            _WasmUnitModelControls.ModifiedDate.EstadoHabilitado(false);
            _WasmUnitModelControls.ModifiedBy.EstadoHabilitado(false);
            _WasmUnitModelControls.DeletedDate.EstadoHabilitado(false);
            _WasmUnitModelControls.DeletedBy.EstadoHabilitado(false);
            _WasmUnitModelControls.Nombre.EstadoHabilitado(false);
            _WasmUnitModelControls.FechaDeNacimiento.EstadoHabilitado(false);
            _WasmUnitModelControls.EstadoCivil.EstadoHabilitado(false);
            _WasmUnitModelControls.Correo.EstadoHabilitado(false);
            _WasmUnitModelControls.Telefono.EstadoHabilitado(false);
            _WasmUnitModelControls.Salario.EstadoHabilitado(false);
            _WasmUnitModelControls.TipoDeEmpleadoId.EstadoHabilitado(false);

            _WasmUnitModelControls.Controles.EstadoNavegacion(false);
            _WasmUnitModelControls.Controles.EstadoBotonesDeDelete(false);
            _WasmUnitModelControls.Controles.EstadoBarraDeTransicion(false);
            _WasmUnitModelControls.Controles.EstadoBotonesDeTransicion(true);
            _WasmUnitModelControls.Compartir.EstadoHabilitado(false);
        }


        public void DarDeBaja()
        {
            _WasmUnitModelControls.Id.EstadoHabilitado(false);
            _WasmUnitModelControls.WoState.EstadoHabilitado(false);
            _WasmUnitModelControls.DeleteInfo.EstadoHabilitado(true);
            _WasmUnitModelControls.SuspendInfo.EstadoHabilitado(false);
            _WasmUnitModelControls.SuspendBy.EstadoHabilitado(false);
            _WasmUnitModelControls.SuspendDate.EstadoHabilitado(false);
            _WasmUnitModelControls.CreatedDate.EstadoHabilitado(false);
            _WasmUnitModelControls.CreatedBy.EstadoHabilitado(false);
            _WasmUnitModelControls.ModifiedDate.EstadoHabilitado(false);
            _WasmUnitModelControls.ModifiedBy.EstadoHabilitado(false);
            _WasmUnitModelControls.DeletedDate.EstadoHabilitado(false);
            _WasmUnitModelControls.DeletedBy.EstadoHabilitado(false);
            _WasmUnitModelControls.Nombre.EstadoHabilitado(false);
            _WasmUnitModelControls.FechaDeNacimiento.EstadoHabilitado(false);
            _WasmUnitModelControls.EstadoCivil.EstadoHabilitado(false);
            _WasmUnitModelControls.Correo.EstadoHabilitado(false);
            _WasmUnitModelControls.Telefono.EstadoHabilitado(false);
            _WasmUnitModelControls.Salario.EstadoHabilitado(false);
            _WasmUnitModelControls.TipoDeEmpleadoId.EstadoHabilitado(false);

            _WasmUnitModelControls.Controles.EstadoNavegacion(false);
            _WasmUnitModelControls.Controles.EstadoBotonesDeDelete(false);
            _WasmUnitModelControls.Controles.EstadoBarraDeTransicion(false);
            _WasmUnitModelControls.Controles.EstadoBotonesDeTransicion(true);
            _WasmUnitModelControls.Compartir.EstadoHabilitado(false);
        }


        public void Modificar()
        {
            _WasmUnitModelControls.Id.EstadoHabilitado(false);
            _WasmUnitModelControls.WoState.EstadoHabilitado(false);
            _WasmUnitModelControls.Nombre.EstadoHabilitado(true);
            _WasmUnitModelControls.FechaDeNacimiento.EstadoHabilitado(true);
            _WasmUnitModelControls.EstadoCivil.EstadoHabilitado(true);
            _WasmUnitModelControls.Correo.EstadoHabilitado(true);
            _WasmUnitModelControls.Telefono.EstadoHabilitado(true);
            _WasmUnitModelControls.Salario.EstadoHabilitado(true);
            _WasmUnitModelControls.TipoDeEmpleadoId.EstadoHabilitado(true);
            _WasmUnitModelControls.SuspendInfo.EstadoHabilitado(false);
            _WasmUnitModelControls.SuspendBy.EstadoHabilitado(false);
            _WasmUnitModelControls.SuspendDate.EstadoHabilitado(false);
            _WasmUnitModelControls.DeleteInfo.EstadoHabilitado(false);
            _WasmUnitModelControls.CreatedDate.EstadoHabilitado(false);
            _WasmUnitModelControls.CreatedBy.EstadoHabilitado(false);
            _WasmUnitModelControls.ModifiedDate.EstadoHabilitado(false);
            _WasmUnitModelControls.ModifiedBy.EstadoHabilitado(false);
            _WasmUnitModelControls.DeletedDate.EstadoHabilitado(false);
            _WasmUnitModelControls.DeletedBy.EstadoHabilitado(false);

            _WasmUnitModelControls.Controles.EstadoNavegacion(false);
            _WasmUnitModelControls.Controles.EstadoBotonesDeDelete(false);
            _WasmUnitModelControls.Controles.EstadoBarraDeTransicion(false);
            _WasmUnitModelControls.Controles.EstadoBotonesDeTransicion(true);
            _WasmUnitModelControls.Compartir.EstadoHabilitado(false);
        }

    }

}



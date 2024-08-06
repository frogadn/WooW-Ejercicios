///------------------------------------------------------------------------------------------------------------------
/// Código autogenerado por la template WoTemplateGenericClass en el path WooW.SB\BlazorGenerator\BlazorTemplates\CommonTemplates\TransitionSettings\WoTemplateTransitionSettingsBlazor.tt
/// Genera código consistente con la version de la prueba de concepto a dia 05-10-2023 En Blazor Wasm y Server
/// Este código es auto generado y su modificación puede causar que el código no se comporte como deveria ademas de
/// que se perderan los cambios realizados en el código al momento de la generación.
///------------------------------------------------------------------------------------------------------------------

using ServerUnitModel_proj.ControlModels;

namespace ServerUnitModel_proj.TransitionSettings
{
    
    public class ServerUnitModelTransitionSettings
    {

        #region Constructor

        /// <summary>
        /// Asigna las instancias inyectadas desde el despachador de dependencias de blazor.
        /// <summary>
        public ServerUnitModelTransitionSettings( ServerUnitModelControls _ServerUnitModelControls)
        {
            this._ServerUnitModelControls = _ServerUnitModelControls;
            
        }

        #endregion Constructor

        #region Atributos

        /// <summary>
        /// Inyección de la clase que contiene las vistas de los controles de la vista.
        /// </summary>
        public ServerUnitModelControls _ServerUnitModelControls { get; set; }

        

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

            _ServerUnitModelControls.Id.EstadoHabilitado(false);


            _ServerUnitModelControls.WoState.EstadoHabilitado(false);


            _ServerUnitModelControls.SuspendInfo.EstadoHabilitado(false);


            _ServerUnitModelControls.SuspendBy.EstadoHabilitado(false);


            _ServerUnitModelControls.SuspendDate.EstadoHabilitado(false);


            _ServerUnitModelControls.DeleteInfo.EstadoHabilitado(false);


            _ServerUnitModelControls.CreatedDate.EstadoHabilitado(false);


            _ServerUnitModelControls.CreatedBy.EstadoHabilitado(false);


            _ServerUnitModelControls.ModifiedDate.EstadoHabilitado(false);


            _ServerUnitModelControls.ModifiedBy.EstadoHabilitado(false);


            _ServerUnitModelControls.DeletedDate.EstadoHabilitado(false);


            _ServerUnitModelControls.DeletedBy.EstadoHabilitado(false);


            _ServerUnitModelControls.Nombre.EstadoHabilitado(false);


            _ServerUnitModelControls.FechaDeNacimiento.EstadoHabilitado(false);


            _ServerUnitModelControls.EstadoCivil.EstadoHabilitado(false);


            _ServerUnitModelControls.Correo.EstadoHabilitado(false);


            _ServerUnitModelControls.Telefono.EstadoHabilitado(false);


            _ServerUnitModelControls.Salario.EstadoHabilitado(false);


            _ServerUnitModelControls.TipoDeEmpleadoId.EstadoHabilitado(false);


            _ServerUnitModelControls.Controles.EstadoNavegacion(true);
            _ServerUnitModelControls.Controles.EstadoBotonesDeDelete(true);
            _ServerUnitModelControls.Controles.EstadoBarraDeTransicion(true);
            _ServerUnitModelControls.Controles.EstadoBotonesDeTransicion(false);
            _ServerUnitModelControls.Compartir.EstadoHabilitado(true);

        }

        private void NavigationModeNoReg()
        {


            _ServerUnitModelControls.Id.EstadoHabilitado(false);


            _ServerUnitModelControls.WoState.EstadoHabilitado(false);


            _ServerUnitModelControls.SuspendInfo.EstadoHabilitado(false);


            _ServerUnitModelControls.SuspendBy.EstadoHabilitado(false);


            _ServerUnitModelControls.SuspendDate.EstadoHabilitado(false);


            _ServerUnitModelControls.DeleteInfo.EstadoHabilitado(false);


            _ServerUnitModelControls.CreatedDate.EstadoHabilitado(false);


            _ServerUnitModelControls.CreatedBy.EstadoHabilitado(false);


            _ServerUnitModelControls.ModifiedDate.EstadoHabilitado(false);


            _ServerUnitModelControls.ModifiedBy.EstadoHabilitado(false);


            _ServerUnitModelControls.DeletedDate.EstadoHabilitado(false);


            _ServerUnitModelControls.DeletedBy.EstadoHabilitado(false);


            _ServerUnitModelControls.Nombre.EstadoHabilitado(false);


            _ServerUnitModelControls.FechaDeNacimiento.EstadoHabilitado(false);


            _ServerUnitModelControls.EstadoCivil.EstadoHabilitado(false);


            _ServerUnitModelControls.Correo.EstadoHabilitado(false);


            _ServerUnitModelControls.Telefono.EstadoHabilitado(false);


            _ServerUnitModelControls.Salario.EstadoHabilitado(false);


            _ServerUnitModelControls.TipoDeEmpleadoId.EstadoHabilitado(false);


            _ServerUnitModelControls.Controles.EstadoNavegacion(false);
            _ServerUnitModelControls.Controles.EstadoBotonesDeDelete(false);
            _ServerUnitModelControls.Controles.EstadoBarraDeTransicion(true);
            _ServerUnitModelControls.Controles.EstadoBotonesDeTransicion(false);
            _ServerUnitModelControls.Compartir.EstadoHabilitado(true);

        }

        public void Nuevo()
        {
            _ServerUnitModelControls.WoState.EstadoHabilitado(false);
            _ServerUnitModelControls.Id.EstadoHabilitado(true);
            _ServerUnitModelControls.Nombre.EstadoHabilitado(true);
            _ServerUnitModelControls.FechaDeNacimiento.EstadoHabilitado(true);
            _ServerUnitModelControls.EstadoCivil.EstadoHabilitado(true);
            _ServerUnitModelControls.Correo.EstadoHabilitado(true);
            _ServerUnitModelControls.Telefono.EstadoHabilitado(true);
            _ServerUnitModelControls.Salario.EstadoHabilitado(true);
            _ServerUnitModelControls.TipoDeEmpleadoId.EstadoHabilitado(true);
            _ServerUnitModelControls.SuspendInfo.EstadoHabilitado(false);
            _ServerUnitModelControls.SuspendBy.EstadoHabilitado(false);
            _ServerUnitModelControls.SuspendDate.EstadoHabilitado(false);
            _ServerUnitModelControls.DeleteInfo.EstadoHabilitado(false);
            _ServerUnitModelControls.CreatedDate.EstadoHabilitado(false);
            _ServerUnitModelControls.CreatedBy.EstadoHabilitado(false);
            _ServerUnitModelControls.ModifiedDate.EstadoHabilitado(false);
            _ServerUnitModelControls.ModifiedBy.EstadoHabilitado(false);
            _ServerUnitModelControls.DeletedDate.EstadoHabilitado(false);
            _ServerUnitModelControls.DeletedBy.EstadoHabilitado(false);

            _ServerUnitModelControls.Controles.EstadoNavegacion(false);
            _ServerUnitModelControls.Controles.EstadoBotonesDeDelete(false);
            _ServerUnitModelControls.Controles.EstadoBarraDeTransicion(false);
            _ServerUnitModelControls.Controles.EstadoBotonesDeTransicion(true);
            _ServerUnitModelControls.Compartir.EstadoHabilitado(false);
        }


        public void Activar()
        {
            _ServerUnitModelControls.Id.EstadoHabilitado(false);
            _ServerUnitModelControls.WoState.EstadoHabilitado(false);
            _ServerUnitModelControls.SuspendInfo.EstadoHabilitado(false);
            _ServerUnitModelControls.SuspendBy.EstadoHabilitado(false);
            _ServerUnitModelControls.SuspendDate.EstadoHabilitado(false);
            _ServerUnitModelControls.DeleteInfo.EstadoHabilitado(false);
            _ServerUnitModelControls.CreatedDate.EstadoHabilitado(false);
            _ServerUnitModelControls.CreatedBy.EstadoHabilitado(false);
            _ServerUnitModelControls.ModifiedDate.EstadoHabilitado(false);
            _ServerUnitModelControls.ModifiedBy.EstadoHabilitado(false);
            _ServerUnitModelControls.DeletedDate.EstadoHabilitado(false);
            _ServerUnitModelControls.DeletedBy.EstadoHabilitado(false);
            _ServerUnitModelControls.Nombre.EstadoHabilitado(false);
            _ServerUnitModelControls.FechaDeNacimiento.EstadoHabilitado(false);
            _ServerUnitModelControls.EstadoCivil.EstadoHabilitado(false);
            _ServerUnitModelControls.Correo.EstadoHabilitado(false);
            _ServerUnitModelControls.Telefono.EstadoHabilitado(false);
            _ServerUnitModelControls.Salario.EstadoHabilitado(false);
            _ServerUnitModelControls.TipoDeEmpleadoId.EstadoHabilitado(false);

            _ServerUnitModelControls.Controles.EstadoNavegacion(false);
            _ServerUnitModelControls.Controles.EstadoBotonesDeDelete(false);
            _ServerUnitModelControls.Controles.EstadoBarraDeTransicion(false);
            _ServerUnitModelControls.Controles.EstadoBotonesDeTransicion(true);
            _ServerUnitModelControls.Compartir.EstadoHabilitado(false);
        }


        public void Suspender()
        {
            _ServerUnitModelControls.Id.EstadoHabilitado(false);
            _ServerUnitModelControls.WoState.EstadoHabilitado(false);
            _ServerUnitModelControls.SuspendInfo.EstadoHabilitado(true);
            _ServerUnitModelControls.SuspendBy.EstadoHabilitado(false);
            _ServerUnitModelControls.SuspendDate.EstadoHabilitado(false);
            _ServerUnitModelControls.DeleteInfo.EstadoHabilitado(false);
            _ServerUnitModelControls.CreatedDate.EstadoHabilitado(false);
            _ServerUnitModelControls.CreatedBy.EstadoHabilitado(false);
            _ServerUnitModelControls.ModifiedDate.EstadoHabilitado(false);
            _ServerUnitModelControls.ModifiedBy.EstadoHabilitado(false);
            _ServerUnitModelControls.DeletedDate.EstadoHabilitado(false);
            _ServerUnitModelControls.DeletedBy.EstadoHabilitado(false);
            _ServerUnitModelControls.Nombre.EstadoHabilitado(false);
            _ServerUnitModelControls.FechaDeNacimiento.EstadoHabilitado(false);
            _ServerUnitModelControls.EstadoCivil.EstadoHabilitado(false);
            _ServerUnitModelControls.Correo.EstadoHabilitado(false);
            _ServerUnitModelControls.Telefono.EstadoHabilitado(false);
            _ServerUnitModelControls.Salario.EstadoHabilitado(false);
            _ServerUnitModelControls.TipoDeEmpleadoId.EstadoHabilitado(false);

            _ServerUnitModelControls.Controles.EstadoNavegacion(false);
            _ServerUnitModelControls.Controles.EstadoBotonesDeDelete(false);
            _ServerUnitModelControls.Controles.EstadoBarraDeTransicion(false);
            _ServerUnitModelControls.Controles.EstadoBotonesDeTransicion(true);
            _ServerUnitModelControls.Compartir.EstadoHabilitado(false);
        }


        public void DarDeBaja()
        {
            _ServerUnitModelControls.Id.EstadoHabilitado(false);
            _ServerUnitModelControls.WoState.EstadoHabilitado(false);
            _ServerUnitModelControls.DeleteInfo.EstadoHabilitado(true);
            _ServerUnitModelControls.SuspendInfo.EstadoHabilitado(false);
            _ServerUnitModelControls.SuspendBy.EstadoHabilitado(false);
            _ServerUnitModelControls.SuspendDate.EstadoHabilitado(false);
            _ServerUnitModelControls.CreatedDate.EstadoHabilitado(false);
            _ServerUnitModelControls.CreatedBy.EstadoHabilitado(false);
            _ServerUnitModelControls.ModifiedDate.EstadoHabilitado(false);
            _ServerUnitModelControls.ModifiedBy.EstadoHabilitado(false);
            _ServerUnitModelControls.DeletedDate.EstadoHabilitado(false);
            _ServerUnitModelControls.DeletedBy.EstadoHabilitado(false);
            _ServerUnitModelControls.Nombre.EstadoHabilitado(false);
            _ServerUnitModelControls.FechaDeNacimiento.EstadoHabilitado(false);
            _ServerUnitModelControls.EstadoCivil.EstadoHabilitado(false);
            _ServerUnitModelControls.Correo.EstadoHabilitado(false);
            _ServerUnitModelControls.Telefono.EstadoHabilitado(false);
            _ServerUnitModelControls.Salario.EstadoHabilitado(false);
            _ServerUnitModelControls.TipoDeEmpleadoId.EstadoHabilitado(false);

            _ServerUnitModelControls.Controles.EstadoNavegacion(false);
            _ServerUnitModelControls.Controles.EstadoBotonesDeDelete(false);
            _ServerUnitModelControls.Controles.EstadoBarraDeTransicion(false);
            _ServerUnitModelControls.Controles.EstadoBotonesDeTransicion(true);
            _ServerUnitModelControls.Compartir.EstadoHabilitado(false);
        }


        public void Modificar()
        {
            _ServerUnitModelControls.Id.EstadoHabilitado(false);
            _ServerUnitModelControls.WoState.EstadoHabilitado(false);
            _ServerUnitModelControls.Nombre.EstadoHabilitado(true);
            _ServerUnitModelControls.FechaDeNacimiento.EstadoHabilitado(true);
            _ServerUnitModelControls.EstadoCivil.EstadoHabilitado(true);
            _ServerUnitModelControls.Correo.EstadoHabilitado(true);
            _ServerUnitModelControls.Telefono.EstadoHabilitado(true);
            _ServerUnitModelControls.Salario.EstadoHabilitado(true);
            _ServerUnitModelControls.TipoDeEmpleadoId.EstadoHabilitado(true);
            _ServerUnitModelControls.SuspendInfo.EstadoHabilitado(false);
            _ServerUnitModelControls.SuspendBy.EstadoHabilitado(false);
            _ServerUnitModelControls.SuspendDate.EstadoHabilitado(false);
            _ServerUnitModelControls.DeleteInfo.EstadoHabilitado(false);
            _ServerUnitModelControls.CreatedDate.EstadoHabilitado(false);
            _ServerUnitModelControls.CreatedBy.EstadoHabilitado(false);
            _ServerUnitModelControls.ModifiedDate.EstadoHabilitado(false);
            _ServerUnitModelControls.ModifiedBy.EstadoHabilitado(false);
            _ServerUnitModelControls.DeletedDate.EstadoHabilitado(false);
            _ServerUnitModelControls.DeletedBy.EstadoHabilitado(false);

            _ServerUnitModelControls.Controles.EstadoNavegacion(false);
            _ServerUnitModelControls.Controles.EstadoBotonesDeDelete(false);
            _ServerUnitModelControls.Controles.EstadoBarraDeTransicion(false);
            _ServerUnitModelControls.Controles.EstadoBotonesDeTransicion(true);
            _ServerUnitModelControls.Compartir.EstadoHabilitado(false);
        }

    }

}



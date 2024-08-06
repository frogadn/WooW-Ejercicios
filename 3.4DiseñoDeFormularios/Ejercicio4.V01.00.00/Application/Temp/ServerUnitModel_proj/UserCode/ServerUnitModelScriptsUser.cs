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
    public partial class ServerUnitModelScriptsUser
{
    /// <summary>
    /// Permite al usuario detonar un evento de actualización de la vista.
    /// </summary>
    public Action? StateHasChangeEvt { get; set; }
    /// <summary>
    /// Indica cual es la transición en la que se encuentra el formulario actualmente.
    /// </summary>
    public string Transicion { get; set; } = "Navegacion";
#region Atributos (modelos y controles)
    /// <summary>
    /// Cliente que se puede usar en el codigo para llamar a los servicios.
    /// </summary>
    public JsonApiClient woTarget { get; set; }

    /// <summary>
    /// Instancia de la clase que contiene los valores bindeados a los controles de la vista.
    /// </summary>
    public Empleado Empleado = new Empleado();
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

    public void FormSettings()
    {
        ///Todo, vistas para los contenedores vista de Root.
        EmpleadoControles.Root.ColorDeFondo(eGroupColor.Background);
        EmpleadoControles.Root.GrosorDeLetra(eTextWeight.Normal);
        EmpleadoControles.Root.Italica(eTextItalic.None);
        EmpleadoControles.Root.DecoracionDeLetra(eTextDecoration.None);
        ///Todo, vistas para los contenedores vista de tabGroupBase.
        EmpleadoControles.tabGroupBase.GrosorDeLetra(eTextWeight.Normal);
        EmpleadoControles.tabGroupBase.Italica(eTextItalic.None);
        EmpleadoControles.tabGroupBase.DecoracionDeLetra(eTextDecoration.None);
        ///Todo, vistas para los contenedores vista de formFormModel.
        EmpleadoControles.formFormModel.GrosorDeLetra(eTextWeight.Normal);
        EmpleadoControles.formFormModel.Italica(eTextItalic.None);
        EmpleadoControles.formFormModel.DecoracionDeLetra(eTextDecoration.None);
        // Start code for Id
        EmpleadoControles.IdContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        EmpleadoControles.Id.GrosorDeLetraDeControl(eTextWeight.Normal);
        EmpleadoControles.Id.ControlEnItalica(eTextItalic.None);
        EmpleadoControles.IdContainer.TtuloEnItalica(eTextItalic.None);
        EmpleadoControles.IdContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        EmpleadoControles.Id.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for Nombre
        EmpleadoControles.NombreContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        EmpleadoControles.Nombre.GrosorDeLetraDeControl(eTextWeight.Normal);
        EmpleadoControles.Nombre.ControlEnItalica(eTextItalic.None);
        EmpleadoControles.NombreContainer.TtuloEnItalica(eTextItalic.None);
        EmpleadoControles.NombreContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        EmpleadoControles.Nombre.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for FechaDeNacimiento
        EmpleadoControles.FechaDeNacimientoContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        EmpleadoControles.FechaDeNacimiento.GrosorDeLetraDeControl(eTextWeight.Normal);
        EmpleadoControles.FechaDeNacimiento.ControlEnItalica(eTextItalic.None);
        EmpleadoControles.FechaDeNacimientoContainer.TtuloEnItalica(eTextItalic.None);
        EmpleadoControles.FechaDeNacimientoContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        EmpleadoControles.FechaDeNacimiento.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for EstadoCivil
        EmpleadoControles.EstadoCivilContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        EmpleadoControles.EstadoCivil.GrosorDeLetraDeControl(eTextWeight.Normal);
        EmpleadoControles.EstadoCivil.ControlEnItalica(eTextItalic.None);
        EmpleadoControles.EstadoCivilContainer.TtuloEnItalica(eTextItalic.None);
        EmpleadoControles.EstadoCivilContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        EmpleadoControles.EstadoCivil.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for Salario
        EmpleadoControles.SalarioContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        EmpleadoControles.Salario.GrosorDeLetraDeControl(eTextWeight.Normal);
        EmpleadoControles.Salario.ControlEnItalica(eTextItalic.None);
        EmpleadoControles.SalarioContainer.TtuloEnItalica(eTextItalic.None);
        EmpleadoControles.SalarioContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        EmpleadoControles.Salario.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for Correo
        EmpleadoControles.CorreoContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        EmpleadoControles.Correo.GrosorDeLetraDeControl(eTextWeight.Normal);
        EmpleadoControles.Correo.ControlEnItalica(eTextItalic.None);
        EmpleadoControles.CorreoContainer.TtuloEnItalica(eTextItalic.None);
        EmpleadoControles.CorreoContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        EmpleadoControles.Correo.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for Telefono
        EmpleadoControles.TelefonoContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        EmpleadoControles.Telefono.GrosorDeLetraDeControl(eTextWeight.Normal);
        EmpleadoControles.Telefono.ControlEnItalica(eTextItalic.None);
        EmpleadoControles.TelefonoContainer.TtuloEnItalica(eTextItalic.None);
        EmpleadoControles.TelefonoContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        EmpleadoControles.Telefono.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for TipoDeEmpleadoId
        EmpleadoControles.TipoDeEmpleadoIdContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        EmpleadoControles.TipoDeEmpleadoId.GrosorDeLetraDeControl(eTextWeight.Normal);
        EmpleadoControles.TipoDeEmpleadoId.ControlEnItalica(eTextItalic.None);
        EmpleadoControles.TipoDeEmpleadoIdContainer.TtuloEnItalica(eTextItalic.None);
        EmpleadoControles.TipoDeEmpleadoIdContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        EmpleadoControles.TipoDeEmpleadoId.DecoracionDeLetraDeControl(eTextDecoration.None);
        ///Todo, vistas para los contenedores vista de formControlform.
        EmpleadoControles.formControlform.GrosorDeLetra(eTextWeight.Normal);
        EmpleadoControles.formControlform.Italica(eTextItalic.None);
        EmpleadoControles.formControlform.DecoracionDeLetra(eTextDecoration.None);
        // Start code for WoState
        EmpleadoControles.WoStateContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        EmpleadoControles.WoState.GrosorDeLetraDeControl(eTextWeight.Normal);
        EmpleadoControles.WoState.ControlEnItalica(eTextItalic.None);
        EmpleadoControles.WoStateContainer.TtuloEnItalica(eTextItalic.None);
        EmpleadoControles.WoStateContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        EmpleadoControles.WoState.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for CreatedDate
        EmpleadoControles.CreatedDateContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        EmpleadoControles.CreatedDate.GrosorDeLetraDeControl(eTextWeight.Normal);
        EmpleadoControles.CreatedDate.ControlEnItalica(eTextItalic.None);
        EmpleadoControles.CreatedDateContainer.TtuloEnItalica(eTextItalic.None);
        EmpleadoControles.CreatedDateContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        EmpleadoControles.CreatedDate.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for CreatedBy
        EmpleadoControles.CreatedByContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        EmpleadoControles.CreatedBy.GrosorDeLetraDeControl(eTextWeight.Normal);
        EmpleadoControles.CreatedBy.ControlEnItalica(eTextItalic.None);
        EmpleadoControles.CreatedByContainer.TtuloEnItalica(eTextItalic.None);
        EmpleadoControles.CreatedByContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        EmpleadoControles.CreatedBy.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for ModifiedDate
        EmpleadoControles.ModifiedDateContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        EmpleadoControles.ModifiedDate.GrosorDeLetraDeControl(eTextWeight.Normal);
        EmpleadoControles.ModifiedDate.ControlEnItalica(eTextItalic.None);
        EmpleadoControles.ModifiedDateContainer.TtuloEnItalica(eTextItalic.None);
        EmpleadoControles.ModifiedDateContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        EmpleadoControles.ModifiedDate.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for ModifiedBy
        EmpleadoControles.ModifiedByContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        EmpleadoControles.ModifiedBy.GrosorDeLetraDeControl(eTextWeight.Normal);
        EmpleadoControles.ModifiedBy.ControlEnItalica(eTextItalic.None);
        EmpleadoControles.ModifiedByContainer.TtuloEnItalica(eTextItalic.None);
        EmpleadoControles.ModifiedByContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        EmpleadoControles.ModifiedBy.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for SuspendDate
        EmpleadoControles.SuspendDateContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        EmpleadoControles.SuspendDate.GrosorDeLetraDeControl(eTextWeight.Normal);
        EmpleadoControles.SuspendDate.ControlEnItalica(eTextItalic.None);
        EmpleadoControles.SuspendDateContainer.TtuloEnItalica(eTextItalic.None);
        EmpleadoControles.SuspendDateContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        EmpleadoControles.SuspendDate.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for SuspendBy
        EmpleadoControles.SuspendByContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        EmpleadoControles.SuspendBy.GrosorDeLetraDeControl(eTextWeight.Normal);
        EmpleadoControles.SuspendBy.ControlEnItalica(eTextItalic.None);
        EmpleadoControles.SuspendByContainer.TtuloEnItalica(eTextItalic.None);
        EmpleadoControles.SuspendByContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        EmpleadoControles.SuspendBy.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for SuspendInfo
        EmpleadoControles.SuspendInfoContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        EmpleadoControles.SuspendInfo.GrosorDeLetraDeControl(eTextWeight.Normal);
        EmpleadoControles.SuspendInfo.ControlEnItalica(eTextItalic.None);
        EmpleadoControles.SuspendInfoContainer.TtuloEnItalica(eTextItalic.None);
        EmpleadoControles.SuspendInfoContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        EmpleadoControles.SuspendInfo.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for DeletedDate
        EmpleadoControles.DeletedDateContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        EmpleadoControles.DeletedDate.GrosorDeLetraDeControl(eTextWeight.Normal);
        EmpleadoControles.DeletedDate.ControlEnItalica(eTextItalic.None);
        EmpleadoControles.DeletedDateContainer.TtuloEnItalica(eTextItalic.None);
        EmpleadoControles.DeletedDateContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        EmpleadoControles.DeletedDate.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for DeletedBy
        EmpleadoControles.DeletedByContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        EmpleadoControles.DeletedBy.GrosorDeLetraDeControl(eTextWeight.Normal);
        EmpleadoControles.DeletedBy.ControlEnItalica(eTextItalic.None);
        EmpleadoControles.DeletedByContainer.TtuloEnItalica(eTextItalic.None);
        EmpleadoControles.DeletedByContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        EmpleadoControles.DeletedBy.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for DeleteInfo
        EmpleadoControles.DeleteInfoContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        EmpleadoControles.DeleteInfo.GrosorDeLetraDeControl(eTextWeight.Normal);
        EmpleadoControles.DeleteInfo.ControlEnItalica(eTextItalic.None);
        EmpleadoControles.DeleteInfoContainer.TtuloEnItalica(eTextItalic.None);
        EmpleadoControles.DeleteInfoContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        EmpleadoControles.DeleteInfo.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for Alertas
        // Start code for Controles
        ;
    }

#endregion Formulario
#region Id
    // Este código fue generado por el fichero WoTextEditScriptUser.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditScriptUser.cs.
    // WoWSB por el generador a día 5-10-2023
    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void Id_OnChange()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void Id_OnFocus()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void Id_OnBlur()
    {
    //Coloque su código aquí.
    }

#endregion Id
#region Nombre
    // Este código fue generado por el fichero WoTextEditScriptUser.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditScriptUser.cs.
    // WoWSB por el generador a día 5-10-2023
    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void Nombre_OnChange()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void Nombre_OnFocus()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void Nombre_OnBlur()
    {
    //Coloque su código aquí.
    }

#endregion Nombre
#region FechaDeNacimiento
    // Este código fue generado por el fichero WoDateEditScriptUser.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoDateEdit\WoDateEditScriptUser.cs.
    // WoWSB por el generador a día 5-10-2023
    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void FechaDeNacimiento_OnChange()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void FechaDeNacimiento_OnFocus()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void FechaDeNacimiento_OnBlur()
    {
    //Coloque su código aquí.
    }

#endregion FechaDeNacimiento
#region EstadoCivil
    // Este código fue generado por el fichero WoComboEnumScriptUser.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoComboEnumEdit\WoComboEnumScriptUser.cs.
    // WoWSB por el generador a día 5-10-2023
    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void EstadoCivil_OnChange()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void EstadoCivil_OnFocus()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void EstadoCivil_OnBlur()
    {
    //Coloque su código aquí.
    }

#endregion EstadoCivil
#region Salario
    // Este código fue generado por el fichero WoMaskedEditScriptUser.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoMaskedEdit\WoMaskedEditScriptUser.cs.
    // WoWSB por el generador a día 5-10-2023
    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void Salario_OnChange()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void Salario_OnFocus()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void Salario_OnBlur()
    {
    //Coloque su código aquí.
    }

#endregion Salario
#region Correo
    // Este código fue generado por el fichero WoMaskedEditScriptUser.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoMaskedEdit\WoMaskedEditScriptUser.cs.
    // WoWSB por el generador a día 5-10-2023
    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void Correo_OnChange()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void Correo_OnFocus()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void Correo_OnBlur()
    {
    //Coloque su código aquí.
    }

#endregion Correo
#region Telefono
    // Este código fue generado por el fichero WoMaskedEditScriptUser.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoMaskedEdit\WoMaskedEditScriptUser.cs.
    // WoWSB por el generador a día 5-10-2023
    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void Telefono_OnChange()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void Telefono_OnFocus()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void Telefono_OnBlur()
    {
    //Coloque su código aquí.
    }

#endregion Telefono
#region TipoDeEmpleadoId
    // Este código fue generado por el fichero WoLookUpEditScriptUser.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoLookUpEdit\WoLookUpEditScriptUser.cs.
    // WoWSB por el generador a día 5-10-2023
    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void TipoDeEmpleadoId_OnChange()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void TipoDeEmpleadoId_OnFocus()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void TipoDeEmpleadoId_OnBlur()
    {
    //Coloque su código aquí.
    }

#endregion TipoDeEmpleadoId
#region WoState
    // Este código fue generado por el fichero WoComboEnumScriptUser.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoComboEnumEdit\WoComboEnumScriptUser.cs.
    // WoWSB por el generador a día 5-10-2023
    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void WoState_OnChange()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void WoState_OnFocus()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void WoState_OnBlur()
    {
    //Coloque su código aquí.
    }

#endregion WoState
#region CreatedDate
    // Este código fue generado por el fichero WoDateEditScriptUser.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoDateEdit\WoDateEditScriptUser.cs.
    // WoWSB por el generador a día 5-10-2023
    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void CreatedDate_OnChange()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void CreatedDate_OnFocus()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void CreatedDate_OnBlur()
    {
    //Coloque su código aquí.
    }

#endregion CreatedDate
#region CreatedBy
    // Este código fue generado por el fichero WoTextEditScriptUser.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditScriptUser.cs.
    // WoWSB por el generador a día 5-10-2023
    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void CreatedBy_OnChange()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void CreatedBy_OnFocus()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void CreatedBy_OnBlur()
    {
    //Coloque su código aquí.
    }

#endregion CreatedBy
#region ModifiedDate
    // Este código fue generado por el fichero WoDateEditScriptUser.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoDateEdit\WoDateEditScriptUser.cs.
    // WoWSB por el generador a día 5-10-2023
    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void ModifiedDate_OnChange()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void ModifiedDate_OnFocus()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void ModifiedDate_OnBlur()
    {
    //Coloque su código aquí.
    }

#endregion ModifiedDate
#region ModifiedBy
    // Este código fue generado por el fichero WoTextEditScriptUser.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditScriptUser.cs.
    // WoWSB por el generador a día 5-10-2023
    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void ModifiedBy_OnChange()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void ModifiedBy_OnFocus()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void ModifiedBy_OnBlur()
    {
    //Coloque su código aquí.
    }

#endregion ModifiedBy
#region SuspendDate
    // Este código fue generado por el fichero WoDateEditScriptUser.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoDateEdit\WoDateEditScriptUser.cs.
    // WoWSB por el generador a día 5-10-2023
    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void SuspendDate_OnChange()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void SuspendDate_OnFocus()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void SuspendDate_OnBlur()
    {
    //Coloque su código aquí.
    }

#endregion SuspendDate
#region SuspendBy
    // Este código fue generado por el fichero WoTextEditScriptUser.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditScriptUser.cs.
    // WoWSB por el generador a día 5-10-2023
    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void SuspendBy_OnChange()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void SuspendBy_OnFocus()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void SuspendBy_OnBlur()
    {
    //Coloque su código aquí.
    }

#endregion SuspendBy
#region SuspendInfo
    // Este código fue generado por el fichero WoTextEditScriptUser.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditScriptUser.cs.
    // WoWSB por el generador a día 5-10-2023
    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void SuspendInfo_OnChange()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void SuspendInfo_OnFocus()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void SuspendInfo_OnBlur()
    {
    //Coloque su código aquí.
    }

#endregion SuspendInfo
#region DeletedDate
    // Este código fue generado por el fichero WoDateEditScriptUser.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoDateEdit\WoDateEditScriptUser.cs.
    // WoWSB por el generador a día 5-10-2023
    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void DeletedDate_OnChange()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void DeletedDate_OnFocus()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void DeletedDate_OnBlur()
    {
    //Coloque su código aquí.
    }

#endregion DeletedDate
#region DeletedBy
    // Este código fue generado por el fichero WoTextEditScriptUser.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditScriptUser.cs.
    // WoWSB por el generador a día 5-10-2023
    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void DeletedBy_OnChange()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void DeletedBy_OnFocus()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void DeletedBy_OnBlur()
    {
    //Coloque su código aquí.
    }

#endregion DeletedBy
#region DeleteInfo
    // Este código fue generado por el fichero WoTextEditScriptUser.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoTextEdit\WoTextEditScriptUser.cs.
    // WoWSB por el generador a día 5-10-2023
    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void DeleteInfo_OnChange()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void DeleteInfo_OnFocus()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void DeleteInfo_OnBlur()
    {
    //Coloque su código aquí.
    }

    public ServerUnitModelScriptsUser(IJSRuntime JS, ServerUnitModelControls EmpleadoControles)
    {
        this.EmpleadoControles = EmpleadoControles;
        this.JS = JS;
    }

#endregion DeleteInfo
    public IJSRuntime JS { get; set; }
    public ServerUnitModelControls EmpleadoControles { get; set; }
}
}


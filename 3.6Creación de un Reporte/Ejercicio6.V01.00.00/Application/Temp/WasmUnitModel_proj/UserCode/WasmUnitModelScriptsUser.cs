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
using WasmUnitModel_proj.ControlModels;
using System.Threading.Tasks;
using FluentValidation;

using WooW.Model;

using ServiceStack;

using WooW.DTO;

using WooW.Blazor;
using WooW.Blazor.Resources; 

using Microsoft.JSInterop;


namespace WasmUnitModel_proj.UserCode
{
    public partial class WasmUnitModelScriptsUser
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
    public TipoDeEmpleado TipoDeEmpleado = new TipoDeEmpleado();
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
        TipoDeEmpleadoControles.Root.ColorDeFondo(eGroupColor.Background);
        TipoDeEmpleadoControles.Root.GrosorDeLetra(eTextWeight.Normal);
        TipoDeEmpleadoControles.Root.Italica(eTextItalic.None);
        TipoDeEmpleadoControles.Root.DecoracionDeLetra(eTextDecoration.None);
        ///Todo, vistas para los contenedores vista de tabGroupBase.
        TipoDeEmpleadoControles.tabGroupBase.GrosorDeLetra(eTextWeight.Normal);
        TipoDeEmpleadoControles.tabGroupBase.Italica(eTextItalic.None);
        TipoDeEmpleadoControles.tabGroupBase.DecoracionDeLetra(eTextDecoration.None);
        ///Todo, vistas para los contenedores vista de formFormModel.
        TipoDeEmpleadoControles.formFormModel.GrosorDeLetra(eTextWeight.Normal);
        TipoDeEmpleadoControles.formFormModel.Italica(eTextItalic.None);
        TipoDeEmpleadoControles.formFormModel.DecoracionDeLetra(eTextDecoration.None);
        // Start code for Id
        TipoDeEmpleadoControles.IdContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        TipoDeEmpleadoControles.Id.GrosorDeLetraDeControl(eTextWeight.Normal);
        TipoDeEmpleadoControles.Id.ControlEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.IdContainer.TtuloEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.IdContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        TipoDeEmpleadoControles.Id.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for Nombre
        TipoDeEmpleadoControles.NombreContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        TipoDeEmpleadoControles.Nombre.GrosorDeLetraDeControl(eTextWeight.Normal);
        TipoDeEmpleadoControles.Nombre.ControlEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.NombreContainer.TtuloEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.NombreContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        TipoDeEmpleadoControles.Nombre.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for Descripcion
        TipoDeEmpleadoControles.DescripcionContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        TipoDeEmpleadoControles.Descripcion.GrosorDeLetraDeControl(eTextWeight.Normal);
        TipoDeEmpleadoControles.Descripcion.ControlEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.DescripcionContainer.TtuloEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.DescripcionContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        TipoDeEmpleadoControles.Descripcion.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for TieneBeneficios
        ///Todo, vistas para los contenedores vista de formControlform.
        TipoDeEmpleadoControles.formControlform.GrosorDeLetra(eTextWeight.Normal);
        TipoDeEmpleadoControles.formControlform.Italica(eTextItalic.None);
        TipoDeEmpleadoControles.formControlform.DecoracionDeLetra(eTextDecoration.None);
        // Start code for WoState
        TipoDeEmpleadoControles.WoStateContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        TipoDeEmpleadoControles.WoState.GrosorDeLetraDeControl(eTextWeight.Normal);
        TipoDeEmpleadoControles.WoState.ControlEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.WoStateContainer.TtuloEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.WoStateContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        TipoDeEmpleadoControles.WoState.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for CreatedDate
        TipoDeEmpleadoControles.CreatedDateContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        TipoDeEmpleadoControles.CreatedDate.GrosorDeLetraDeControl(eTextWeight.Normal);
        TipoDeEmpleadoControles.CreatedDate.ControlEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.CreatedDateContainer.TtuloEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.CreatedDateContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        TipoDeEmpleadoControles.CreatedDate.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for CreatedBy
        TipoDeEmpleadoControles.CreatedByContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        TipoDeEmpleadoControles.CreatedBy.GrosorDeLetraDeControl(eTextWeight.Normal);
        TipoDeEmpleadoControles.CreatedBy.ControlEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.CreatedByContainer.TtuloEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.CreatedByContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        TipoDeEmpleadoControles.CreatedBy.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for ModifiedDate
        TipoDeEmpleadoControles.ModifiedDateContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        TipoDeEmpleadoControles.ModifiedDate.GrosorDeLetraDeControl(eTextWeight.Normal);
        TipoDeEmpleadoControles.ModifiedDate.ControlEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.ModifiedDateContainer.TtuloEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.ModifiedDateContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        TipoDeEmpleadoControles.ModifiedDate.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for ModifiedBy
        TipoDeEmpleadoControles.ModifiedByContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        TipoDeEmpleadoControles.ModifiedBy.GrosorDeLetraDeControl(eTextWeight.Normal);
        TipoDeEmpleadoControles.ModifiedBy.ControlEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.ModifiedByContainer.TtuloEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.ModifiedByContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        TipoDeEmpleadoControles.ModifiedBy.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for SuspendDate
        TipoDeEmpleadoControles.SuspendDateContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        TipoDeEmpleadoControles.SuspendDate.GrosorDeLetraDeControl(eTextWeight.Normal);
        TipoDeEmpleadoControles.SuspendDate.ControlEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.SuspendDateContainer.TtuloEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.SuspendDateContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        TipoDeEmpleadoControles.SuspendDate.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for SuspendBy
        TipoDeEmpleadoControles.SuspendByContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        TipoDeEmpleadoControles.SuspendBy.GrosorDeLetraDeControl(eTextWeight.Normal);
        TipoDeEmpleadoControles.SuspendBy.ControlEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.SuspendByContainer.TtuloEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.SuspendByContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        TipoDeEmpleadoControles.SuspendBy.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for SuspendInfo
        TipoDeEmpleadoControles.SuspendInfoContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        TipoDeEmpleadoControles.SuspendInfo.GrosorDeLetraDeControl(eTextWeight.Normal);
        TipoDeEmpleadoControles.SuspendInfo.ControlEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.SuspendInfoContainer.TtuloEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.SuspendInfoContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        TipoDeEmpleadoControles.SuspendInfo.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for DeletedDate
        TipoDeEmpleadoControles.DeletedDateContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        TipoDeEmpleadoControles.DeletedDate.GrosorDeLetraDeControl(eTextWeight.Normal);
        TipoDeEmpleadoControles.DeletedDate.ControlEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.DeletedDateContainer.TtuloEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.DeletedDateContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        TipoDeEmpleadoControles.DeletedDate.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for DeletedBy
        TipoDeEmpleadoControles.DeletedByContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        TipoDeEmpleadoControles.DeletedBy.GrosorDeLetraDeControl(eTextWeight.Normal);
        TipoDeEmpleadoControles.DeletedBy.ControlEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.DeletedByContainer.TtuloEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.DeletedByContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        TipoDeEmpleadoControles.DeletedBy.DecoracionDeLetraDeControl(eTextDecoration.None);
        // Start code for DeleteInfo
        TipoDeEmpleadoControles.DeleteInfoContainer.GrosorDeLetraDeTitulo(eTextWeight.Normal);
        TipoDeEmpleadoControles.DeleteInfo.GrosorDeLetraDeControl(eTextWeight.Normal);
        TipoDeEmpleadoControles.DeleteInfo.ControlEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.DeleteInfoContainer.TtuloEnItalica(eTextItalic.None);
        TipoDeEmpleadoControles.DeleteInfoContainer.DecoracionDeLetraDeTitulo(eTextDecoration.None);
        TipoDeEmpleadoControles.DeleteInfo.DecoracionDeLetraDeControl(eTextDecoration.None);
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
#region Descripcion
    // Este código fue generado por el fichero WoMemoEditScriptUser.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoMemoEdit\WoMemoEditScriptUser.cs.
    // WoWSB por el generador a día 5-10-2023
    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void Descripcion_OnChange()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void Descripcion_OnFocus()
    {
    //Coloque su código aquí.
    }

    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void Descripcion_OnBlur()
    {
    //Coloque su código aquí.
    }

#endregion Descripcion
#region TieneBeneficios
    // Este código fue generado por el fichero WoCheckBoxEditScriptUser.cs en el Path: WooW.SB\BlazorGenerator\BlazorComponents\BlazorInputs\WoCheckBoxEdit\WoCheckBoxEditScriptUser.cs.
    // WoWSB por el generador a día 5-10-2023
    /// <summary>
    /// Evento que se cacha cuando existe un cambio.
    /// </summary>
    public void TieneBeneficios_OnChange()
    {
    //Coloque su código aquí.
    }

    public void TieneBeneficios_OnFocus()
    {
    //Coloque su código aquí.
    }

    public void TieneBeneficios_OnBlur()
    {
    //Coloque su código aquí.
    }

#endregion TieneBeneficios
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

#endregion DeleteInfo
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

    public WasmUnitModelScriptsUser(IJSRuntime JS, WasmUnitModelControls TipoDeEmpleadoControles)
    {
        this.TipoDeEmpleadoControles = TipoDeEmpleadoControles;
        this.JS = JS;
    }

#endregion DeletedBy
    public IJSRuntime JS { get; set; }
    public WasmUnitModelControls TipoDeEmpleadoControles { get; set; }
}
}


///------------------------------------------------------------------------------------------------------------------
/// Código autogenerado por la template WoTemplateGenericClass en el path WooW.SB\WooW.SB\BlazorGenerator\BlazorTemplates\CommonTemplates\Pages\WoTemplateIndexPartialBlazor.tt
/// Genera código consistente con la version de la prueba de concepto a dia 05-10-2023 En Blazor Wasm y Server
/// Este código es auto generado y su modificación puede causar que el código no se comporte como deveria ademas de
/// que se perderan los cambios realizados en el código al momento de la generación.
///------------------------------------------------------------------------------------------------------------------

namespace WasmUnitModel_proj.Pages
{
    public partial class Index
    {
        
            protected override async Task OnAfterRenderAsync(bool firstRender)
            {
                await base.OnAfterRenderAsync(firstRender);

                if (NavigationManager != null)
                {
                    NavigationManager.NavigateTo("/Index");
                }
            }
    }
}


///------------------------------------------------------------------------------------------------------------------
/// Código autogenerado por la template WoTemplateGenericClass en el path WooW.SB\BlazorGenerator\BlazorTemplates\WasmTemplates\Localizer\WoTemplateWebAssemblyHostExtensionsWasm.tt
/// Genera código consistente con la version de la prueba de concepto a dia 05-10-2023 En Blazor Wasm y Server
/// Este código es auto generado y su modificación puede causar que el código no se comporte como deveria ademas de
/// que se perderan los cambios realizados en el código al momento de la generación.
///------------------------------------------------------------------------------------------------------------------

using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Globalization;
using WasmUnitModel_proj.Localizer;

namespace WasmUnitModel_proj.Localizer
{
    public static class WebAssemblyHostExtensions
    {
        /// <summary>
        /// Metodo de extención para el objeto de app y permite que se asigne la cultura base sea inicializada.
        /// Igual permite que se inicialize el localizer una vez se inicia la aplicación.
        /// El metodo se manda a llamar desde el Program.cs
        /// </summary>
        /// <param name="host"></param>
        /// <returns></returns>
        public async static Task SetDefaultCulture(this WebAssemblyHost host)
        {
            var localStorage = host.Services.GetRequiredService<ILocalStorageService>();
            var cultureString = await localStorage.GetItemAsync<string>("culture");

            CultureInfo cultureInfo;

            if (!string.IsNullOrWhiteSpace(cultureString))
            {
                cultureInfo = new CultureInfo(cultureString);
            }
            else
            {
                cultureInfo = new CultureInfo(LocalizerSettings.NeutralCulture.Name);
            }

            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
        }
    }

}



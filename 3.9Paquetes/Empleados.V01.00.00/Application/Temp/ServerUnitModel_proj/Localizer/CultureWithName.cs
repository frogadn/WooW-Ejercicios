///------------------------------------------------------------------------------------------------------------------
/// Código autogenerado por la template WoTemplateGenericClass en el path WooW.SB\WooW.SB\BlazorGenerator\BlazorTemplates\CommonTemplates\Localizer\WoTemplateCultureWithNameBlazor.tt
/// Genera código consistente con la version de la prueba de concepto a dia 05-10-2023 En Blazor Wasm y Server
/// Este código es auto generado y su modificación puede causar que el código no se comporte como deveria ademas de
/// que se perderan los cambios realizados en el código al momento de la generación.
///------------------------------------------------------------------------------------------------------------------

namespace ServerUnitModel_proj.Localizer
{
    public record CultureWithName
    {
        public string Name { get; init; } = default!;
        public string Culture { get; init; } = default!;

        public CultureWithName(string name, string culture)
        {
            Name = name;
            Culture = culture;
        }
    }
}


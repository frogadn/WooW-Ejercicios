///------------------------------------------------------------------------------------------------------------------
/// Código autogenerado por la template WoTemplateGenericClass en el path WooW.SB\BlazorGenerator\BlazorTemplates\CommonTemplates\FluentValidators\WoTemplateInstanciaUdnAsignarValidatorBlazor.tt
/// Genera código consistente con la version de la prueba de concepto a dia 05-10-2023 En Blazor Wasm y Server
/// Este código es auto generado y su modificación puede causar que el código no se comporte como deveria ademas de
/// que se perderan los cambios realizados en el código al momento de la generación.
///------------------------------------------------------------------------------------------------------------------

using FluentValidation;
using WooW.Core;

namespace WasmUnitModel_proj.FluentValidators
{
    public class InstanciaUdnAsignarValidator : AbstractValidator<WoInstanciaUdnAsignar>
    {

        /// <summary>
        /// Constructor principal de la clase fluent que permite definir las reglas de validación.
        /// </summary>
        public InstanciaUdnAsignarValidator()
        {
            RuleFor(x => x.Instance).NotEmpty().WithMessage("La instancia es requerida.");
            RuleFor(x => x.Udn).NotEmpty().WithMessage("La UDN es requerida.");
            RuleFor(x => x.Year).Must(x => x < 2020).WithMessage("El año almenos deve de ser 2020.");
        }

    }
}


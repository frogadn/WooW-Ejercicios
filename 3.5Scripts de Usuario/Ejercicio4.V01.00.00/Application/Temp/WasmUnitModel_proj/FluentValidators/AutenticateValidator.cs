///------------------------------------------------------------------------------------------------------------------
/// Código autogenerado por la template WoTemplateGenericClass en el path WooW.SB\BlazorGenerator\BlazorTemplates\CommonTemplates\FluentValidators\WoTemplateAutenticateValidatorBlazor.tt
/// Genera código consistente con la version de la prueba de concepto a dia 05-10-2023 En Blazor Wasm y Server
/// Este código es auto generado y su modificación puede causar que el código no se comporte como deveria ademas de
/// que se perderan los cambios realizados en el código al momento de la generación.
///------------------------------------------------------------------------------------------------------------------

using FluentValidation;
using ServiceStack;

namespace WasmUnitModel_proj.FluentValidators
{
    public class AutenticateValidator : AbstractValidator<Authenticate>
    {
        /// <summary>
        /// Constructor principal de la clase fluent que permite definir las reglas de validación.
        /// </summary>
        public AutenticateValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("El usuario es requerido.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("La contraseña es requerida.");
        }
    }
}


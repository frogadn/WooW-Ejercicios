
using FluentValidation;
using WooW.Model;

namespace WasmUnitModel_proj.FluentValidators
{
    public class WasmUnitModelValidator : AbstractValidator<Empleado>
{
    public WasmUnitModelValidator()
    {
        RuleFor(x => x.Salario).GreaterThan(0).WithMessage("El salario debe ser mayor a 0.");
    }
}
}


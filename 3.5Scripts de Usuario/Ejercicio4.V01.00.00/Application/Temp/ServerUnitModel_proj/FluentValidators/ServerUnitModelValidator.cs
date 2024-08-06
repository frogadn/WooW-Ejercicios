
using FluentValidation;
using WooW.Model;

namespace ServerUnitModel_proj.FluentValidators
{
    public class ServerUnitModelValidator : AbstractValidator<Empleado>
{
    public ServerUnitModelValidator()
    {
        RuleFor(x => x.Salario).GreaterThan(0).WithMessage("El salario debe ser mayor a 0.");
    }
}
}


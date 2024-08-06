
public class EmpleadoValidator : AbstractValidator<Empleado>
{
    public EmpleadoValidator()
    {
        RuleFor(x => x.Salario).GreaterThan(0).WithMessage("El salario debe ser mayor a 0.");
    }
}


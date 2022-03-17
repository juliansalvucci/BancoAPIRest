using FluentValidation;

namespace Application.Features.Clientes.Commands.CreateClienteCommand
{
    public class CreateClienteCommandValidator : AbstractValidator<CreateClienteCommand>
    {
        public CreateClienteCommandValidator()
        {
            RuleFor(p => p.Nombre).NotEmpty()
                .WithMessage("{PropertyName} no puede ser vacio")
                .MaximumLength(80).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");

            RuleFor(p => p.Apellido).NotEmpty()
                .WithMessage("{PropertyName} no puede ser vacio")
                .MaximumLength(80).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");

            RuleFor(p => p.FechaNacimiento).NotEmpty()
                .WithMessage("{PropertyName} no puede ser vacio");

            RuleFor(p => p.Telefono).NotEmpty()
                .WithMessage("{PropertyName} no puede ser vacio")
                .Matches(@"^\d{4}-\d{4}$").WithMessage("{PropertyName} debe cumplir el formato 0000-0000")
                .MaximumLength(9).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");

            RuleFor(p => p.Email).NotEmpty()
                .WithMessage("{PropertyName} no puede ser vacio")
                .EmailAddress().WithMessage("{PropertyName} debe ser una dirección de mail válida")
                .MaximumLength(100).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");

            RuleFor(p => p.Direccion).NotEmpty()
                .WithMessage("{PropertyName} no puede ser vacio")
                .EmailAddress().WithMessage("{PropertyName} debe ser una dirección de mail válida")
                .MaximumLength(100).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");



        }
    }
}

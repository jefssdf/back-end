using FluentValidation;
using System.Text.RegularExpressions;

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.CreateLegalEntity
{
    public class CreateLegalEntityValidator : AbstractValidator<CreateLegalEntityRequest>
    {
        public CreateLegalEntityValidator() 
        {
            RuleFor(le => le.name).NotEmpty().NotNull()
                .WithMessage("Nome é um campo obrigatório.")
                .MinimumLength(3).MaximumLength(70);
            RuleFor(le => le.email).NotEmpty().NotNull()
                .WithMessage("Email é um campo obrigatório.")
                .MaximumLength(70).EmailAddress();
            RuleFor(le => le.password).NotEmpty().NotNull()
                .WithMessage("Senha é um campo obrigatório.")
                .MinimumLength(8). MaximumLength(30);
            RuleFor(le => le.phoneNumber).NotEmpty().NotNull()
                .WithMessage("Contato de celular é um campo obrigatório.")
                .Matches(new Regex("^\\(?[1-9]{2}\\)? ?(?:[2-8]|9[0-9])[0-9]{3}\\-?[0-9]{4}$"))
                .WithMessage("Número inserido inválido.");
        }

    }
}

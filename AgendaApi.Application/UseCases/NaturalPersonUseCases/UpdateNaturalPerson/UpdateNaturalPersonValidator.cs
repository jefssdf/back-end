using FluentValidation;
using System.Text.RegularExpressions;

namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.UpdateNaturalPerson
{
    public class UpdateNaturalPersonValidator : AbstractValidator<UpdateNaturalPersonRequest>
    {
        public UpdateNaturalPersonValidator() 
        {
            RuleFor(np => np.id).NotEmpty();
            RuleFor(np => np.name).NotEmpty()
                .WithMessage("Nome é um campo obrigatório.")
                .MinimumLength(3).MaximumLength(70);
            RuleFor(np => np.email).NotEmpty()
                .WithMessage("Email é um campo obrigatório.")
                .MaximumLength(70).EmailAddress();
            RuleFor(np => np.password).NotEmpty()
                .WithMessage("Senha é um campo obrigatório.")
                .MinimumLength(8).MaximumLength(30);
            RuleFor(np => np.phoneNumber).NotEmpty()
                .WithMessage("Contato celular é um campo obrigatório.")
                .Matches(new Regex("^\\(?[1-9]{2}\\)? ?(?:[2-8]|9[0-9])[0-9]{3}\\-?[0-9]{4}$"))
                .WithMessage("Número inserido inválido.");
        }
    }
}

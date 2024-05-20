

using AgendaApi.Application.UseCases.NaturalPersonUseCases.CreateNaturalPerson;
using FluentValidation;
using System.Text.RegularExpressions;

namespace AgendaApi.Application.UseCases.NaturalPersonUsecases.CreateNaturalPerson
{
    public sealed class CreateNaturalPersonValidator : AbstractValidator<CreateNaturalPersonRequest>
    {
        public CreateNaturalPersonValidator() 
        {
            RuleFor(np => np.name).NotEmpty()
                .WithMessage("Nome é um campo obrigatório")
                .MinimumLength(3).MaximumLength(70);
            RuleFor(np => np.email).NotEmpty()
                .WithMessage("Email é um campo obrigatório")
                .MaximumLength(70).EmailAddress();
            RuleFor(np => np.password).NotEmpty()
                .WithMessage("Senha é um campo obrigatório")
                .MinimumLength(8).MaximumLength(30);
            RuleFor(np => np.phoneNumber).NotEmpty()
                .WithMessage("Contato celular é um campo obrigatório")
                .Matches(new Regex("^\\(?[1-9]{2}\\)? ?(?:[2-8]|9[0-9])[0-9]{3}\\-?[0-9]{4}$"))
                .WithMessage("Número inserido inválido");
            RuleFor(np => np.address).NotEmpty()
                .WithMessage("Endereço é um campo obrigatório")
                .MaximumLength(100);
            RuleFor(np => np.cpf).NotEmpty()
                .WithMessage("Cpf é um campo obrigatório")
                .MaximumLength(15);
            RuleFor(np => np.birthDate).NotEmpty()
                .WithMessage("Data de nascimento é um campo obrigatório")
                .LessThan(np => DateTime.Now).WithMessage("Data inválida");
        }
    }
}

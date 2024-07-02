using FluentValidation;

namespace AgendaApi.Application.UseCases.AuthenticationUseCases.Login
{
    public class LoginValidator : AbstractValidator<LoginRequest>
    {
        public LoginValidator() 
        {
            RuleFor(l => l.email).NotEmpty().NotNull()
                .WithMessage("Email é um campo obrigatório.")
                .MaximumLength(70).EmailAddress();
            RuleFor(l => l.password).NotEmpty().NotNull()
                .WithMessage("Senha é um campo obrigatório.")
                .MinimumLength(8).MaximumLength(30);
        }
    }
}

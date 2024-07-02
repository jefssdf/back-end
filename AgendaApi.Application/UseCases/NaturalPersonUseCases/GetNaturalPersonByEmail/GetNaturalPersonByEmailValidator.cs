using FluentValidation;

namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.GetNaturalPersonByEmail
{
    public class GetNaturalPersonByEmailValidator : AbstractValidator<GetNaturalPersonByEmailRequest>
    {
        public GetNaturalPersonByEmailValidator() 
        {
            RuleFor(np => np.email).NotEmpty().NotNull()
                .WithMessage("Email é um campo obrigatório.")
                .MaximumLength(70).EmailAddress();
        }
    }
}

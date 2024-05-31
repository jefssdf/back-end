using FluentValidation;

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.GetLegalEntityByEmail
{
    public class GetLegalEntityByEmailValidator : AbstractValidator<GetLegalEntityByEmailRequest>
    {
        public GetLegalEntityByEmailValidator()
        {
            RuleFor(le => le.email).NotEmpty()
                .WithMessage("Email é um campo obrigatório.")
                .MaximumLength(70).EmailAddress();
        }
    }
}

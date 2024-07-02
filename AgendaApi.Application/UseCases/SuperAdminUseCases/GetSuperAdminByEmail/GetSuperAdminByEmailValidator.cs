using AgendaApi.Application.UseCases.SuperAdminUseCases.DTOs;
using FluentValidation;

namespace AgendaApi.Application.UseCases.SuperAdminUseCases.GetSuperAdminByEmail
{
    public class GetSuperAdminByEmailValidator : AbstractValidator<GetSuperAdminByEmailRequest>
    {
        public GetSuperAdminByEmailValidator() 
        {
            RuleFor(sa => sa.email).NotEmpty().NotNull()
                .EmailAddress()
                .WithMessage("O campo email é necessário.");
        }
    }
}

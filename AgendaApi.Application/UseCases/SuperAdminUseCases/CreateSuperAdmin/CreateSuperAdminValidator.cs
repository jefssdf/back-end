using FluentValidation;

namespace AgendaApi.Application.UseCases.SuperAdminUseCases.CreateSuperAdmin
{
    public class CreateSuperAdminValidator : AbstractValidator<CreateSuperAdminRequest>
    {
        public CreateSuperAdminValidator() 
        {
            RuleFor(sa => sa.email).NotEmpty().NotNull()
                .WithMessage("Campo email é obrigatório.")
                .EmailAddress();
            RuleFor(sa => sa.password).NotEmpty().NotNull()
                .WithMessage("Senha é um campo obrigatório.");
        }
    }
}

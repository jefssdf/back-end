using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.SuperAdminUseCases.UpdateSuperAdmin
{
    public class UpdateSuperAdminValidator : AbstractValidator<UpdateSuperAdminRequest>
    {
        public UpdateSuperAdminValidator() 
        {
            RuleFor(sa => sa.superAdminId).NotEmpty().NotNull()
                .Must(GuidValidator.BeValid);
            RuleFor(np => np.email).NotEmpty()
                .WithMessage("Email é um campo obrigatório.")
                .MaximumLength(70).EmailAddress();
            RuleFor(np => np.password).NotEmpty()
                .WithMessage("Senha é um campo obrigatório.")
                .MinimumLength(8).MaximumLength(30);
        }
    }
}

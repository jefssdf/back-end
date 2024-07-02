using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.SuperAdminUseCases.DeleteSuperAdmin
{
    public class DeleteSuperAdminValidator : AbstractValidator<DeleteSuperAdminRequest>
    {
        public DeleteSuperAdminValidator() 
        {
            RuleFor(sa => sa.superAdminId).NotEmpty().NotNull()
                .Must(GuidValidator.BeValid);
        }
    }
}

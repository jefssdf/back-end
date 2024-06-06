using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.DeleteScheduling
{
    public class CancelSchedulingValidator : AbstractValidator<CancelSchedulingRequest>
    {
        public CancelSchedulingValidator() 
        {
            RuleFor(s => s.schedulingId).NotEmpty()
                .Must(GuidValidator.BeValid);
            RuleFor(s => s.owner).NotEmpty()
                .Must(GuidValidator.BeValid);
        }
    }
}

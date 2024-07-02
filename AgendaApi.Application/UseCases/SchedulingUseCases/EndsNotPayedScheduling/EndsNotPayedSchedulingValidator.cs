using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.EndsNotPayedScheduling
{
    public class EndsNotPayedSchedulingValidator : AbstractValidator<EndsNotPayedSchedulingRequest>
    {
        public EndsNotPayedSchedulingValidator() 
        {
            RuleFor(s => s.schedulingId).NotEmpty().NotNull()
                .Must(GuidValidator.BeValid);
        }
    }
}

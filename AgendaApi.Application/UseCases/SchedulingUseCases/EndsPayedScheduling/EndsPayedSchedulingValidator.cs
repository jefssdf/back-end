using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.ConfirmeScheduling
{
    public class EndsPayedSchedulingValidator : AbstractValidator<EndsPayedSchedulingRequest>
    {
        public EndsPayedSchedulingValidator() 
        {
            RuleFor(s => s.schedulingId).NotEmpty().NotNull()
                .Must(GuidValidator.BeValid);
        }
    }
}

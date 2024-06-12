using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.ConfirmeScheduling
{
    public class EndsSchedulingValidator : AbstractValidator<EndsSchedulingRequest>
    {
        public EndsSchedulingValidator() 
        {
            RuleFor(s => s.schedulingId).NotEmpty()
                .Must(GuidValidator.BeValid);
        }
    }
}

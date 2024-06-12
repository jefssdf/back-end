using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.ConfirmeScheduling
{
    public class ConfirmeSchedulingValidator : AbstractValidator<ConfirmeSchedulingRequest>
    {
        public ConfirmeSchedulingValidator() 
        {
            RuleFor(s => s.schedulingId).NotEmpty()
                .Must(GuidValidator.BeValid);
        }
    }
}

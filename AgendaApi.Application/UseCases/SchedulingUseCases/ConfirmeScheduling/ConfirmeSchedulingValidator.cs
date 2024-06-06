using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.ConfirmeScheduling
{
    public class ConfirmeSchedulingValidator : AbstractValidator<ConfirmeSchedulingRequest>
    {
        public ConfirmeSchedulingValidator() 
        {
            RuleFor(s => s.id).NotEmpty()
                .Must(GuidValidator.BeValid);
        }
    }
}

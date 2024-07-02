using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.CreateScheduling
{
    public class CreateSchedulingValidator : AbstractValidator<CreateSchedulingRequest>
    {
        public CreateSchedulingValidator() 
        {
            RuleFor(s => s.schedulingDate).NotEmpty().NotNull()
                .GreaterThan(DateTime.Now);
            RuleFor(s => s.naturalPersonId).NotEmpty().NotNull()
                .Must(GuidValidator.BeValid);
            RuleFor(s => s.legalEntityId).NotEmpty().NotNull()
                .Must(GuidValidator.BeValid);
            RuleFor(s => s.serviceId).NotEmpty().NotNull()
                .Must(GuidValidator.BeValid);
        }
    }
}
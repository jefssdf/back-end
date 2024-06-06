using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.CreateScheduling
{
    public class CreateSchedulingValidator : AbstractValidator<CreateSchedulingRequest>
    {
        public CreateSchedulingValidator() 
        {
            RuleFor(s => s.schedulingDate).NotEmpty()
                .LessThan(DateTime.Now);
            RuleFor(s => s.naturalPersonId).NotEmpty()
                .Must(GuidValidator.BeValid);
            RuleFor(s => s.legalEntityId).NotEmpty()
                .Must(GuidValidator.BeValid);
            RuleFor(s => s.serviceId).NotEmpty()
                .Must(GuidValidator.BeValid);
        }
    }
}
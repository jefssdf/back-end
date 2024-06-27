using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.GetAllNaturalPersonSchedulingsBySchedulingStatus
{
    public class GetAllNaturalPersonSchedulingsBySchedulingStatusValidator 
        : AbstractValidator<GetAllNaturalPersonSchedulingsBySchedulingStatusRequest>
    {
        public GetAllNaturalPersonSchedulingsBySchedulingStatusValidator() 
        {
            RuleFor(s => s.naturalPersonId).NotEmpty()
                .Must(GuidValidator.BeValid);
            RuleFor(s => s.schedulingStatusId).NotEmpty()
                .InclusiveBetween(1, 4)
                .WithMessage("SchedulingStatusId deve estar entre 1 e 4.");
        }
    }
}

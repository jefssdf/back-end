using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.SchedulingStatusUseCase.UpdateSchedulingStatus
{
    public class UpdateSchedulingStatusValidator 
        : AbstractValidator<UpdateSchedulingStatusRequest>
    {
        public UpdateSchedulingStatusValidator() 
        {
            RuleFor(ss => ss.id).NotEmpty();
            RuleFor(ss => ss.statusName).NotEmpty();
        }
    }
}

using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.SchedulingStatusUseCase.UpdateSchedulingStatus
{
    public class UpdateSchedulingStatusValidator 
        : AbstractValidator<UpdateSchedulingStatusRequest>
    {
        public UpdateSchedulingStatusValidator() 
        {
            RuleFor(ss => ss.schedulingStatusId).NotEmpty().NotNull();
            RuleFor(ss => ss.statusName).NotEmpty().NotNull();
        }
    }
}

using FluentValidation;

namespace AgendaApi.Application.UseCases.SchedulingStatusUseCase.CreateSchedulingStatus
{
    public class CreateSchedulingStatusValidator : AbstractValidator<CreateSchedulingStatusRequest>
    {
        public CreateSchedulingStatusValidator() 
        {
            RuleFor(ss => ss.SchedulingStatusId).NotEmpty().NotNull();
            RuleFor(ss => ss.statusName).NotEmpty().NotNull();
        }
    }
}
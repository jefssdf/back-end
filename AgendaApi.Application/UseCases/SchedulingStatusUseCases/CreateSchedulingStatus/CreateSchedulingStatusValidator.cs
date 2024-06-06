using FluentValidation;

namespace AgendaApi.Application.UseCases.SchedulingStatusUseCase.CreateSchedulingStatus
{
    public class CreateSchedulingStatusValidator : AbstractValidator<CreateSchedulingStatusRequest>
    {
        public CreateSchedulingStatusValidator() 
        {
            RuleFor(ss => ss.statusName).NotEmpty();
        }
    }
}
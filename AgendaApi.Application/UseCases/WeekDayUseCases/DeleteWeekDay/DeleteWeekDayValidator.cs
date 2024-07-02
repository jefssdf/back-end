using FluentValidation;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.DeleteWeekDay
{
    public class DeleteWeekDayValidator : AbstractValidator<DeleteWeekDayRequest>
    {
        public DeleteWeekDayValidator() 
        {
            RuleFor(wd => wd.id).NotEmpty().NotNull();
        }
    }
}

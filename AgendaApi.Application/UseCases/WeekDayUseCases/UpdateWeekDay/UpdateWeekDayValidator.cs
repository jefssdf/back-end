using FluentValidation;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.UpdateWeekDay
{
    public class UpdateWeekDayValidator : AbstractValidator<UpdateWeekDayRequest>
    {
        public UpdateWeekDayValidator() 
        {
            RuleFor(wd => wd.id)
                .NotEmpty();
            RuleFor(wd => wd.name)
                .NotEmpty();
        }
    }
}

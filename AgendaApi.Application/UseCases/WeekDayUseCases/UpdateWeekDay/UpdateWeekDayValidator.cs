using FluentValidation;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.UpdateWeekDay
{
    public class UpdateWeekDayValidator : AbstractValidator<UpdateWeekDayRequest>
    {
        public UpdateWeekDayValidator() 
        {
            RuleFor(wd => wd.id)
                .NotEmpty().NotNull();
            RuleFor(wd => wd.name)
                .NotEmpty().NotNull();
        }
    }
}

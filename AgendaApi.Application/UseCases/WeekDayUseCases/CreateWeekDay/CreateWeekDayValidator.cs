using FluentValidation;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.CreateWeekDay
{
    public class CreateWeekDayValidator : AbstractValidator<CreateWeekDayRequest>
    {
        public CreateWeekDayValidator()
        {
            RuleFor(wd => wd.WeekDayId).NotEmpty().NotNull();
            RuleFor(wd => wd.name).NotEmpty().NotNull();
        }
    }
}

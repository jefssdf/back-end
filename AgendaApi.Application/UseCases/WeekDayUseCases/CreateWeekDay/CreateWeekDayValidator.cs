using FluentValidation;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.CreateWeekDay
{
    public class CreateWeekDayValidator : AbstractValidator<CreateWeekDayRequest>
    {
        public CreateWeekDayValidator()
        {
            RuleFor(wd => wd.weekDayId).NotEmpty()
                .InclusiveBetween(0, 6)
                .WithMessage("O dia da semana deve estar entre 0 (domingo) e 6 (sábado).");
            RuleFor(wd => wd.name).NotEmpty();
        }
    }
}

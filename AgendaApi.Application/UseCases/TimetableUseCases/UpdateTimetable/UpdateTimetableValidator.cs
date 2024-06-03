using FluentValidation;

namespace AgendaApi.Application.UseCases.TimetableUseCases.UpdateTimetable
{
    public class UpdateTimetableValidator : AbstractValidator<UpdateTimetableRequest>
    {
        public UpdateTimetableValidator() 
        {
            RuleFor(tt => tt.id).NotEmpty();
            RuleFor(tt => tt.startTime).NotEmpty()
                .Must(TimeOnlyValidFormat)
                .WithMessage("O tempo deve estar no formato HH:mm.");
            RuleFor(tt => tt.endTime).NotEmpty()
                .Must(TimeOnlyValidFormat)
                .WithMessage("O tempo deve estar no formato HH:mm.");
            RuleFor(tt => tt.legalEntityId).NotEmpty();
            RuleFor(tt => tt.weekDayId).NotEmpty()
                .InclusiveBetween(1, 7)
                .WithMessage("O identificador do dia da semana deve estar entre 1 e 7.");
        }
        private bool TimeOnlyValidFormat(TimeOnly time) =>
            TimeOnly.TryParseExact(time.ToString(), "HH:mm", out _);
    }
}

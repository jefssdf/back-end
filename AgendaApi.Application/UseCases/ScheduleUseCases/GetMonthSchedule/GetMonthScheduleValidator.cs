using FluentValidation;

namespace AgendaApi.Application.UseCases.ScheduleUseCases.GetMonthSchedule
{
    public class GetMonthScheduleValidator : AbstractValidator<GetMonthScheduleRequest>
    {
        public GetMonthScheduleValidator() 
        {
            RuleFor(s => s.date).NotEmpty().NotNull()
                .WithMessage("É necessário uma data como referência para filtrar os agendamentos");
            RuleFor(s => s.legalEntityId).NotEmpty().NotNull();
        }
    }
}

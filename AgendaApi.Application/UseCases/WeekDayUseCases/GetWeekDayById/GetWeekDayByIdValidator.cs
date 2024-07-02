using FluentValidation;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.GetWeekDayById
{
    public class GetWeekDayByIdValidator : AbstractValidator<GetWeekDayByIdRequest>
    {
        public GetWeekDayByIdValidator() 
        {
            RuleFor(wd => wd.id).NotEmpty().NotNull();
        }
    }
}

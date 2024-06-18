using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.GetAllWeekDay
{
    public class GetAllWeekDayValidator 
        : AbstractValidator<GetAllWeekDayRequest>
    {
        public GetAllWeekDayValidator() 
        {
            RuleFor(wd => wd.legalEntityId).NotEmpty()
                .Must(GuidValidator.BeValid);
        }
    }
}

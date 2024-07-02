using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.TimetableUseCases.GetAllTimetables
{
    public class GetAllTimetablesValidator 
        : AbstractValidator<GetAllTimetablesRequest>
    {
        public GetAllTimetablesValidator() 
        {
            RuleFor(tt => tt.legalEntityId).NotEmpty().NotNull()
                .Must(GuidValidator.BeValid);
        }
    }
}

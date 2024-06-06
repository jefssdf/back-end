using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.GetAllSchedulingByNaturalPerson
{
    public class GetAllSchedulingByNaturalPersonValidator : AbstractValidator<GetAllSchedulingByNaturalPersonRequest>
    {
        public GetAllSchedulingByNaturalPersonValidator() 
        {
            RuleFor(s => s.id).NotEmpty()
                .Must(GuidValidator.BeValid);
        }
    }
}

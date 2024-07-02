using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.GetSchedulingById
{
    public class GetSchedulingByIdValidator : AbstractValidator<GetSchedulingByIdRequest>
    {
        public GetSchedulingByIdValidator() 
        {
            RuleFor(s => s.id).NotEmpty().NotNull()
                .Must(GuidValidator.BeValid);
        }
    }
}

using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.SchedulingStatusUseCase.GetSchedulingStatusById
{
    public class GetSchedulingStatusByIdValidator : AbstractValidator<GetSchedulingStatusByIdRequest>
    {
        public GetSchedulingStatusByIdValidator() 
        {
            RuleFor(ss => ss.id).NotEmpty();
        }
    }
}

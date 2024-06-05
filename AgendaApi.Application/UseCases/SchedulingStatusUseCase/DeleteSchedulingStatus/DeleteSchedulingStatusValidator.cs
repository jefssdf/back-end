using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.SchedulingStatusUseCase.DeleteSchedulingStatus
{
    public class DeleteSchedulingStatusValidator : AbstractValidator<DeleteSchedulingStatusRequest>
    {
        public DeleteSchedulingStatusValidator() 
        {
            RuleFor(ss => ss.id).NotEmpty()
                .Must(GuidValidator.BeValid);
        }
    }
}

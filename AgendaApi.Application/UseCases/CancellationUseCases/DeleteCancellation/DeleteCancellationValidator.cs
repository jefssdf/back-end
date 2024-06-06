using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.CancellationUseCase.DeleteCancellation
{
    public class DeleteCancellationValidator : AbstractValidator<DeleteCancellationRequest>
    {
        public DeleteCancellationValidator() 
        {
            RuleFor(c => c.id).NotEmpty()
                .Must(GuidValidator.BeValid);
        }
    }
}

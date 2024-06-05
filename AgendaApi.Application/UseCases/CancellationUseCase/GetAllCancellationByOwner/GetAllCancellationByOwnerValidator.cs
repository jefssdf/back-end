using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.CancellationUseCase.GetAllCancellationByOwner
{
    public class GetAllCancellationByOwnerValidator : AbstractValidator<GetAllCancellationByOwnerRequest>
    {
        public GetAllCancellationByOwnerValidator() 
        {
            RuleFor(c => c.id).NotEmpty()
                .Must(GuidValidator.BeValid);
        }
    }
}

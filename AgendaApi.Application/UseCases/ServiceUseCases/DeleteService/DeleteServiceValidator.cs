using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.ServiceUseCase.DeleteService
{
    public class DeleteServiceValidator : AbstractValidator<DeleteServiceRequest>
    {
        public DeleteServiceValidator() 
        {
            RuleFor(s => s.id).NotEmpty()
                .Must(GuidValidator.BeValid);
        }
    }
}

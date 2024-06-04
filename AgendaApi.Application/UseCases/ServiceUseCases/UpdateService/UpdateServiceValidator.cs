using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.ServiceUseCase.UpdateService
{
    public class UpdateServiceValidator : AbstractValidator<UpdateServiceRequest>
    {
        public UpdateServiceValidator() 
        {
            RuleFor(s => s.name).NotEmpty()
                .WithMessage("Nome é um campo obrigatório")
                .MinimumLength(3).MaximumLength(70);
            RuleFor(s => s.description).NotEmpty();
            RuleFor(s => s.legalEntityId).NotEmpty()
                .Must(GuidValidator.BeValid);
        }
    }
}

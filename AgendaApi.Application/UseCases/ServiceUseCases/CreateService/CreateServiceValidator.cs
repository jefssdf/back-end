using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.ServiceUseCase.CreateService
{
    public class CreateServiceValidator : AbstractValidator<CreateServiceRequest>
    {
        public CreateServiceValidator() 
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
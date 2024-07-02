using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.ServiceUseCase.CreateService
{
    public class CreateServiceValidator : AbstractValidator<CreateServiceRequest>
    {
        public CreateServiceValidator() 
        {
            RuleFor(s => s.name).NotEmpty().NotNull()
                .WithMessage("Nome é um campo obrigatório")
                .MinimumLength(3).MaximumLength(70);
            RuleFor(s => s.description).NotEmpty().NotNull();
            RuleFor(s => s.duration).NotEmpty().NotNull()
                .Must(TimeSpanValidator.BeMultipleOf30Minutes);
            RuleFor(s => s.price).NotEmpty().NotNull();
            RuleFor(s => s.legalEntityId).NotEmpty().NotNull()
                .Must(GuidValidator.BeValid);
        }
    }
}
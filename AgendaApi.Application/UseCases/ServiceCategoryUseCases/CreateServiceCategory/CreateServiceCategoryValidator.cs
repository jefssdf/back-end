
using FluentValidation;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.CreateServiceCategory
{
    public sealed class CreateServiceCategoryValidator 
        : AbstractValidator<CreateServiceCategoryRequest>
    {
        public CreateServiceCategoryValidator() 
        {
            RuleFor(cs => cs.name).NotEmpty()
                .WithMessage("Nome é um campo obrigatório.")
                .MinimumLength(3).MaximumLength(70);
        }
    }
}

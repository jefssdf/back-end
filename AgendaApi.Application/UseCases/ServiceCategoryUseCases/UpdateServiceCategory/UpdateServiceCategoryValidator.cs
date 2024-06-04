using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.UpdateServiceCategory
{
    public class UpdateServiceCategoryValidator : AbstractValidator<UpdateServiceCategoryRequest>
    {
        public UpdateServiceCategoryValidator()
        {
            RuleFor(cs => cs.id).NotEmpty()
               .Must(GuidValidator.BeValid);
            RuleFor(cs => cs.name).NotEmpty()
               .WithMessage("Nome é um campo obrigatório.")
               .MinimumLength(3).MaximumLength(70);
        }
    }
}

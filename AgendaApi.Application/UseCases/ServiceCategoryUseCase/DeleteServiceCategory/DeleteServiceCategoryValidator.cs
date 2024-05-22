using FluentValidation;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.DeleteServiceCategory
{
    public sealed class DeleteServiceCategoryValidator 
        : AbstractValidator<DeleteServiceCategoryRequest>
    {
        public DeleteServiceCategoryValidator() 
        {
            RuleFor(sc => sc.id).NotEmpty();
        }
    }
}

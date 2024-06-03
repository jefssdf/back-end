using FluentValidation;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.GetAllServiceCategory
{
    public sealed class GetAllServiceCategoryValidator 
        : AbstractValidator<GetAllServiceCategoryRequest>
    {
        public GetAllServiceCategoryValidator() { }
    }
}

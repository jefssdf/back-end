using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.GetServiceCategoryById
{
    public class GetServiceCategoryByIdValidator : AbstractValidator<GetServiceCategoryByIdRequest>
    {
        public GetServiceCategoryByIdValidator() 
        {
            RuleFor(cs => cs.id).NotEmpty()
               .Must(GuidValidator.BeValid);
        }
    }
}

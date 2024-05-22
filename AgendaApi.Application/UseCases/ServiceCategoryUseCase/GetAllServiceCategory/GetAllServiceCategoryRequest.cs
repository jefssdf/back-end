using MediatR;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.GetAllServiceCategory
{
    public sealed record GetAllServiceCategoryRequest
        : IRequest<List<GetAllServiceCategoryResponse>>;
}

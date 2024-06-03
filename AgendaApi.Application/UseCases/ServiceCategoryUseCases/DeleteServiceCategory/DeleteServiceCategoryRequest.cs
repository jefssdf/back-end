using MediatR;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.DeleteServiceCategory
{
    public sealed record DeleteServiceCategoryRequest(
        Guid id)
        : IRequest<DeleteServiceCategoryResponse>;
}

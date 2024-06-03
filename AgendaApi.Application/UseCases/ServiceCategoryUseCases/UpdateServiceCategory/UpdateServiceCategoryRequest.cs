using AgendaApi.Domain.Entities;
using MediatR;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.UpdateServiceCategory
{
    public sealed record UpdateServiceCategoryRequest(
        Guid id,
        string? name)
        : IRequest<UpdateServiceCategoryResponse>;
}

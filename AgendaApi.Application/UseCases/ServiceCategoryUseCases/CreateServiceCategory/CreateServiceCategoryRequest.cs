using AgendaApi.Domain.Entities;
using MediatR;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.CreateServiceCategory
{
    public sealed record CreateServiceCategoryRequest(
        string name)
        : IRequest<CreateServiceCategoryResponse>;
}

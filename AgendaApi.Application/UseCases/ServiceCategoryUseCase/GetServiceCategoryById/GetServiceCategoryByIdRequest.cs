using MediatR;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.GetServiceCategoryById
{
    public sealed record GetServiceCategoryByIdRequest(Guid id)
        : IRequest<GetServiceCategoryByIdResponse>;
}

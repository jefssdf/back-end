using MediatR;

namespace AgendaApi.Application.UseCases.CancellationUseCase.GetAllCancellationByOwner
{
    public sealed record GetAllCancellationByOwnerRequest(Guid id)
        : IRequest<List<GetAllCancellationByOwnerResponse>>;
}

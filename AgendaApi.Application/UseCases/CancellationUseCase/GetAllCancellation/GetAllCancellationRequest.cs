using MediatR;

namespace AgendaApi.Application.UseCases.CancellationUseCase.GetAllCancellation
{
    public sealed record GetAllCancellationRequest : IRequest<List<GetAllCancellationResponse>>;
}

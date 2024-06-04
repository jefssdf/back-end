using MediatR;

namespace AgendaApi.Application.UseCases.CancellationUseCase.CreateCancellation
{
    public sealed record CreateCancellationRequest(
                DateTime? cancellationTime, 
                Guid owner, 
                Guid schedulingId)
                : IRequest<CreateCancellationResponse>;
}

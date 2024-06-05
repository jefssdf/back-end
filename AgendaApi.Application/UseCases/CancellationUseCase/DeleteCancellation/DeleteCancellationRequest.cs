using MediatR;

namespace AgendaApi.Application.UseCases.CancellationUseCase.DeleteCancellation
{
    public sealed record DeleteCancellationRequest(Guid id) 
        :IRequest<DeleteCancellationResponse>;
}

using MediatR;

namespace AgendaApi.Application.UseCases.ServiceStatusUsecases.DeleteServiceStatus
{
    public sealed record DeleteServiceStatusRequest(int serviceStatusId)
        : IRequest<DeleteServiceStatusResponse>;
}

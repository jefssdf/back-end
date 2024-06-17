using MediatR;

namespace AgendaApi.Application.UseCases.ServiceStatusUsecases.UpdateServiceStatus
{
    public sealed record UpdateServiceStatusRequest(int serviceStatusId,
        string statusName)
        : IRequest<UpdateServiceStatusResponse>;
}

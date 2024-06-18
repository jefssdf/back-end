using MediatR;

namespace AgendaApi.Application.UseCases.ServiceStatusUsecases.CreateServiceStatus
{
    public sealed record CreateServiceStatusRequest(int serviceStatusId,
        string statusName)
        : IRequest<CreateServiceStatusResponse>;
}

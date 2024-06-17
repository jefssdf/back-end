using MediatR;

namespace AgendaApi.Application.UseCases.ServiceStatusUsecases.CreateServiceStatus
{
    public sealed record CreateServiceStatusRequest(string statusName)
        : IRequest<CreateServiceStatusResponse>;
}

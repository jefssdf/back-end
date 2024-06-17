using MediatR;

namespace AgendaApi.Application.UseCases.ServiceStatusUsecases.GetAllServiceStatus
{
    public sealed record GetAllServiceStatusRequest 
        : IRequest<List<GetAllServiceStatusResponse>>;
}

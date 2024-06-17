using MediatR;

namespace AgendaApi.Application.UseCases.ServiceUseCases.UpdateServiceAvailability
{
    public sealed record UpdateServiceAvailabilityRequest(Guid serviceId,
        int serviceStatusId)
        : IRequest<UpdateServiceAvailabilityResponse>;
}

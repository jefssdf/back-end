using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.CreateScheduling
{
    public sealed record CreateSchedulingRequest(
                    DateTime schedulingDate,  
                    Guid naturalPersonId, 
                    Guid legalEntityId, 
                    Guid serviceId)
                    : IRequest<CreateSchedulingResponse>;
}
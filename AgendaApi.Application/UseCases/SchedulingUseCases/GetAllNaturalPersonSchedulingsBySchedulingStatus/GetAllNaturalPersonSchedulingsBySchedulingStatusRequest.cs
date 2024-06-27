using AutoMapper.Configuration.Conventions;
using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.GetAllNaturalPersonSchedulingsBySchedulingStatus
{
    public sealed record GetAllNaturalPersonSchedulingsBySchedulingStatusRequest(Guid naturalPersonId,
        int schedulingStatusId)
        : IRequest<List<GetAllNaturalPersonSchedulingsBySchedulingStatusResponse>>
    {
    }
}

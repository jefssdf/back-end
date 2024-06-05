using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.SchedulingStatusUseCase.UpdateSchedulingStatus
{
    public sealed class UpdateSchedulingStatusMapper : Profile
    {
        public UpdateSchedulingStatusMapper() 
        {
            CreateMap<UpdateSchedulingStatusRequest, SchedulingStatus>();
            CreateMap<SchedulingStatus, UpdateSchedulingStatusResponse>();
        }
    }
}

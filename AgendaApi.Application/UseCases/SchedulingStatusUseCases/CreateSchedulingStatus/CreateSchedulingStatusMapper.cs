using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.SchedulingStatusUseCase.CreateSchedulingStatus
{
    public sealed class CreateSchedulingStatusMapper : Profile
    {
        public CreateSchedulingStatusMapper() 
        {
            CreateMap<CreateSchedulingStatusRequest, SchedulingStatus>();
            CreateMap<SchedulingStatus, CreateSchedulingStatusResponse>();
        }
    }
}

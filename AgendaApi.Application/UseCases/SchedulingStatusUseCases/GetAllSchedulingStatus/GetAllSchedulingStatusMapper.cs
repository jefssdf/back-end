using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.SchedulingStatusUseCase.GetAllSchedulingStatus
{
    public sealed class GetAllSchedulingStatusMapper : Profile
    {
        public GetAllSchedulingStatusMapper() 
        {
            CreateMap<SchedulingStatus, GetAllSchedulingStatusResponse>();
        }
    }
}

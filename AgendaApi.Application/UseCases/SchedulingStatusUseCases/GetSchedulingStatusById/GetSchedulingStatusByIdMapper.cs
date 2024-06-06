using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.SchedulingStatusUseCase.GetSchedulingStatusById
{
    public sealed class GetSchedulingStatusByIdMapper : Profile
    {
        public GetSchedulingStatusByIdMapper() 
        {
            CreateMap<SchedulingStatus, GetSchedulingStatusByIdResponse>();
        }
    }
}

using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.SchedulingStatusUseCase.DeleteSchedulingStatus
{
    public sealed class DeleteSchedulingStatusMapper : Profile
    {
        public DeleteSchedulingStatusMapper() 
        {
            CreateMap<SchedulingStatus, DeleteSchedulingStatusResponse>();
        }
    }
}

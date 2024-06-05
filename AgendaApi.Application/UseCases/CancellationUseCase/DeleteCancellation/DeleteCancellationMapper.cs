using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.CancellationUseCase.DeleteCancellation
{
    public sealed class DeleteCancellationMapper : Profile
    {
        public DeleteCancellationMapper() 
        {
            CreateMap<Cancellation, DeleteCancellationResponse>();
        }
    }
}

using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.CancellationUseCase.GetAllCancellation
{
    public sealed class GetAllCancellationMapper : Profile
    {
        public GetAllCancellationMapper() 
        {
            CreateMap<Cancellation, GetAllCancellationResponse>();
        }
    }
}

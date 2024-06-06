using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.CancellationUseCase.GetAllCancellationByOwner
{
    public sealed class GetAllCancellationByOwnerMapper : Profile
    {
        public GetAllCancellationByOwnerMapper() 
        {
            CreateMap<Cancellation, GetAllCancellationByOwnerResponse>();
        }
    }
}

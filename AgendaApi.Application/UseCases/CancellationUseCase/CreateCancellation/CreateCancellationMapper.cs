using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.CancellationUseCase.CreateCancellation
{
    public sealed class CreateCancellationMapper : Profile
    {
        public CreateCancellationMapper() 
        {
            CreateMap<CreateCancellationRequest, Cancellation>();
            CreateMap<Cancellation, CreateCancellationResponse>();
        }
    }
}

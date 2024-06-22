using AgendaApi.Application.UseCases.ServiceUseCase.GetServiceById;
using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ScheduleUseCases.GetBlockScheduleInfo
{
    public sealed class GetBlockScheduleInfoMapper : Profile
    {
        public GetBlockScheduleInfoMapper() 
        {
            CreateMap<Service, GetServiceByName>();
            CreateMap<NaturalPerson, GetNaturalPersonByName>();
        }
    }
}

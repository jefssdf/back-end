using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.GetServiceCategoryById
{
    public sealed class GetServiceCategoryByIdMapper : Profile
    {
        public GetServiceCategoryByIdMapper() 
        {
            CreateMap<ServiceCategory, GetServiceCategoryByIdResponse>();
        }
    }
}

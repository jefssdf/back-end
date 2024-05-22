using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.GetAllServiceCategory
{
    public sealed class GetAllServiceCategoryMapper : Profile
    {
        public GetAllServiceCategoryMapper() 
        {
            CreateMap<ServiceCategory, GetAllServiceCategoryResponse>();
        }
    }
}

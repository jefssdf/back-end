using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.CreateServiceCategory
{
    public sealed class CreateServiceCategoryMapper : Profile
    {
        public CreateServiceCategoryMapper() 
        {
            CreateMap<CreateServiceCategoryRequest, ServiceCategory>();
            CreateMap<ServiceCategory, CreateServiceCategoryResponse>();
        }
    }
}

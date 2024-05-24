using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.UpdateServiceCategory
{
    public sealed class UpdateServiceCategoryMapper : Profile
    {
        public UpdateServiceCategoryMapper() 
        {
            CreateMap<UpdateServiceCategoryRequest, ServiceCategory>();
            CreateMap<ServiceCategory, UpdateServiceCategoryResponse>();
        }
    }
}

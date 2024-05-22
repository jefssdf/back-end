using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.DeleteServiceCategory
{
    public sealed class DeleteServiceCategoryMapper : Profile
    {
        public DeleteServiceCategoryMapper() 
        {
            CreateMap<ServiceCategory, DeleteServiceCategoryResponse>();
        }
    }
}

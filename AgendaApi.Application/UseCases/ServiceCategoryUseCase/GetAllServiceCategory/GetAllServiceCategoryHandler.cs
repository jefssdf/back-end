using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.GetAllServiceCategory
{
    public sealed class GetAllServiceCategoryHandler
        : IRequestHandler<GetAllServiceCategoryRequest, List<GetAllServiceCategoryResponse>>
    {
        private readonly IServiceCategoryRepository _serviceCategoryRepository;
        private readonly IMapper _mapper;

        public GetAllServiceCategoryHandler(IServiceCategoryRepository serviceCategoryRepository, 
            IMapper mapper)
        {
            _serviceCategoryRepository = serviceCategoryRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllServiceCategoryResponse>> Handle(GetAllServiceCategoryRequest request,
            CancellationToken cancellationToken)
        {
            var servicecategories = await _serviceCategoryRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllServiceCategoryResponse>>(servicecategories);
        }
    }
}

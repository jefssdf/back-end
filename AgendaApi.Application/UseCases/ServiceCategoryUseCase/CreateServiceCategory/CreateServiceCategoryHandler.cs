using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.CreateServiceCategory
{
    public sealed class CreateServiceCategoryHandler
        : IRequestHandler<CreateServiceCategoryRequest, CreateServiceCategoryResponse>
    {
        private readonly IServiceCategoryRepository _serviceCategoryRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreateServiceCategoryHandler(IServiceCategoryRepository serviceCategoryRepository,
            IMapper mapper, IUnitOfWork unitOfWork)
        {
            _serviceCategoryRepository = serviceCategoryRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<CreateServiceCategoryResponse> Handle(CreateServiceCategoryRequest request,
            CancellationToken cancellationToken)
        {
            var serviceCategory = _mapper.Map<ServiceCategory>(request);
            _serviceCategoryRepository.Create(serviceCategory);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CreateServiceCategoryResponse>(serviceCategory);
        }
    }
}

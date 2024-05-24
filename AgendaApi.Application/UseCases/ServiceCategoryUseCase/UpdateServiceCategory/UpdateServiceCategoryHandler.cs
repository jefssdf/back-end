using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.UpdateServiceCategory
{
    public sealed class UpdateServiceCategoryHandler
        : IRequestHandler<UpdateServiceCategoryRequest, UpdateServiceCategoryResponse>
    {
        private readonly IServiceCategoryRepository _serviceCategoryRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateServiceCategoryHandler(IServiceCategoryRepository serviceCategoryRepository,
            IMapper mapper, IUnitOfWork unitOfWork)
        {
            _serviceCategoryRepository = serviceCategoryRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<UpdateServiceCategoryResponse> Handle(UpdateServiceCategoryRequest request,
            CancellationToken cancellationToken)
        {
            var serviceCategory = await _serviceCategoryRepository.GetById(request.id, cancellationToken);
            if (serviceCategory is null) return default;

            serviceCategory.Name = request.name;

            _serviceCategoryRepository.Update(serviceCategory);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateServiceCategoryResponse>(serviceCategory);
        }
    }
}

using AgendaApi.Domain.Interfaces;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.DeleteServiceCategory
{
    public sealed class DeleteServiceCategoryHandler
    {
        private readonly IServiceCategoryRepository _seviceCategoryRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteServiceCategoryHandler(IServiceCategoryRepository seviceCategoryRepository,
            IMapper mapper, IUnitOfWork unitOfWork)
        {
            _seviceCategoryRepository = seviceCategoryRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<DeleteServiceCategoryResponse> Handle(DeleteServiceCategoryRequest request,
            CancellationToken cancellationToken)
        {
            var serviceCategory = await _seviceCategoryRepository.GetById(request.id, cancellationToken);
            if (serviceCategory is null) return default;

            _seviceCategoryRepository.Delete(serviceCategory);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<DeleteServiceCategoryResponse>(serviceCategory);
        }
    }
}

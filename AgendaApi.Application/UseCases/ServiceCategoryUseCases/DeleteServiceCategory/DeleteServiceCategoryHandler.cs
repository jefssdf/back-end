using AgendaApi.Domain.Interfaces;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.DeleteServiceCategory
{
    public sealed class DeleteServiceCategoryHandler
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteServiceCategoryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<DeleteServiceCategoryResponse> Handle(DeleteServiceCategoryRequest request,
            CancellationToken cancellationToken)
        {
            var serviceCategory = await _unitOfWork.ServiceCategoryRepository.GetById(
                sc => sc.ServiceCategoryId == request.id, cancellationToken);
            if (serviceCategory is null) return default;

            _unitOfWork.ServiceCategoryRepository.Delete(serviceCategory);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<DeleteServiceCategoryResponse>(serviceCategory);
        }
    }
}

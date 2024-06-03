using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.CreateServiceCategory
{
    public sealed class CreateServiceCategoryHandler
        : IRequestHandler<CreateServiceCategoryRequest, CreateServiceCategoryResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreateServiceCategoryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<CreateServiceCategoryResponse> Handle(CreateServiceCategoryRequest request,
            CancellationToken cancellationToken)
        {
            var serviceCategory = _mapper.Map<ServiceCategory>(request);
            _unitOfWork.ServiceCategoryRepository.Create(serviceCategory);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CreateServiceCategoryResponse>(serviceCategory);
        }
    }
}

using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.GetAllServiceCategory
{
    public sealed class GetAllServiceCategoryHandler
        : IRequestHandler<GetAllServiceCategoryRequest, List<GetAllServiceCategoryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllServiceCategoryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<GetAllServiceCategoryResponse>> Handle(GetAllServiceCategoryRequest request,
            CancellationToken cancellationToken)
        {
            var servicecategories = await _unitOfWork.ServiceCategoryRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllServiceCategoryResponse>>(servicecategories);
        }
    }
}

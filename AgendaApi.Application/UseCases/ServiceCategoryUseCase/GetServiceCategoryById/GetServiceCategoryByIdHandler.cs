using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.GetServiceCategoryById
{
    public sealed class GetServiceCategoryByIdHandler
        : IRequestHandler<GetServiceCategoryByIdRequest, GetServiceCategoryByIdResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetServiceCategoryByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<GetServiceCategoryByIdResponse> Handle(GetServiceCategoryByIdRequest request,
            CancellationToken cancellationToken)
        {
            var serviceCategory = await _unitOfWork.ServiceCategoryRepository.GetById(
                sc => sc.ServiceCategoryId == request.id, cancellationToken);
            if (serviceCategory is null) return default;

            return _mapper.Map<GetServiceCategoryByIdResponse>(serviceCategory);
        }
    }
}

using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.GetServiceCategoryById
{
    public sealed class GetServiceCategoryByIdHandler
        : IRequestHandler<GetServiceCategoryByIdRequest, GetServiceCategoryByIdResponse>
    {
        private readonly IServiceCategoryRepository _serviceCategoryRepository;
        private readonly IMapper _mapper;

        public GetServiceCategoryByIdHandler(IServiceCategoryRepository serviceCategoryRepository,
            IMapper mapper)
        {
            _serviceCategoryRepository = serviceCategoryRepository;
            _mapper = mapper;
        }

        public async Task<GetServiceCategoryByIdResponse> Handle(GetServiceCategoryByIdRequest request,
            CancellationToken cancellationToken)
        {
            var serviceCategory = await _serviceCategoryRepository.GetById(request.id, cancellationToken);
            if (serviceCategory is null) return default;

            return _mapper.Map<GetServiceCategoryByIdResponse>(serviceCategory);
        }
    }
}

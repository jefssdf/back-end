using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.ServiceUseCase.GetServiceById
{
    public sealed class GetServiceByIdHandler
        : IRequestHandler<GetServiceByIdRequest, GetServiceByIdResponse>
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IMapper _mapper;

        public GetServiceByIdHandler(IServiceRepository serviceRepository,
            IMapper mapper)
        {
            _serviceRepository = serviceRepository;
            _mapper = mapper;
        }

        public async Task<GetServiceByIdResponse> Handle(GetServiceByIdRequest request,
            CancellationToken cancellationToken)
        {
            var service = await _serviceRepository.GetById(request.id, cancellationToken);
            if (service is null) return default;

            return _mapper.Map<GetServiceByIdResponse>(service);
        }
    }
}

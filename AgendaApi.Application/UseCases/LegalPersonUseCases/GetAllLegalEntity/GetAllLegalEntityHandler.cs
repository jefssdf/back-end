using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.GetAllLegalEntity
{
    public sealed class GetAllLegalEntityHandler 
        : IRequestHandler<GetAllLegalEntityRequest, List<GetAllLegalEntityResponse>>
    {
        private readonly ILegalEntityRepository _legalEntityRepository;
        private readonly IMapper _mapper;

        public GetAllLegalEntityHandler(ILegalEntityRepository repository, 
            IMapper mapper) 
        {
            _legalEntityRepository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetAllLegalEntityResponse>> Handle(GetAllLegalEntityRequest request,
            CancellationToken cancellationToken)
        {
            var entities = await _legalEntityRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllLegalEntityResponse>>(entities);
        }
    }
}

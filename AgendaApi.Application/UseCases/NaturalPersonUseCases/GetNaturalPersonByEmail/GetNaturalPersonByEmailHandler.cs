using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.GetNaturalPersonByEmail
{
    public sealed class GetNaturalPersonByEmailHandler
        : IRequestHandler<GetNaturalPersonByEmailRequest, GetNaturalPersonByEmailResponse>
    {
        private readonly INaturalPersonRepository _naturalPersonRepository;
        private readonly IMapper _mapper;

        public GetNaturalPersonByEmailHandler(INaturalPersonRepository naturalPersonRepository, 
            IMapper mapper)
        {
            _naturalPersonRepository = naturalPersonRepository;
            _mapper = mapper;
        }

        public async Task<GetNaturalPersonByEmailResponse> Handle(GetNaturalPersonByEmailRequest request,
            CancellationToken cancellationToken)
        {
            var naturalPerson = await _naturalPersonRepository.GetByEmail(request.email, cancellationToken);
            if (naturalPerson is null) return default;

            return _mapper.Map<GetNaturalPersonByEmailResponse>(naturalPerson);
        }
    }
}

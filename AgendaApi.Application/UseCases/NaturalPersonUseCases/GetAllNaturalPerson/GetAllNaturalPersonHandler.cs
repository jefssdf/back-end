using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.GetAllNaturalPerson
{
    public sealed class GetAllNaturalPersonHandler
        : IRequestHandler<GetAllNaturalPersonRequest, List<GetAllNaturalPersonResponse>>
    {
        private readonly INaturalPersonRepository _naturalPersonRepository;
        private readonly IMapper _mapper;

        public GetAllNaturalPersonHandler(INaturalPersonRepository naturalPersonRepository, 
            IMapper mapper)
        {
            _naturalPersonRepository = naturalPersonRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllNaturalPersonResponse>> Handle(GetAllNaturalPersonRequest request,
            CancellationToken cancellationToken)
        {
            var naturalPersons = await _naturalPersonRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllNaturalPersonResponse>>(naturalPersons);
        }
    }
}

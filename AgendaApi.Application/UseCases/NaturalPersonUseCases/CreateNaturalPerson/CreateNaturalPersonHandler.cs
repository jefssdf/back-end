using AgendaApi.Application.UseCases.LegalPersonUseCases.CreateLegalEntity;
using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.CreateNaturalPerson
{
    public sealed class CreateNaturalPersonHandler :
        IRequestHandler<CreateNaturalPersonRequest, CreateNaturalPersonResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly INaturalPersonRepository _naturalPersonRepository;
        private readonly IMapper _mapper;

        public CreateNaturalPersonHandler(
            IUnitOfWork unitOfWork, INaturalPersonRepository naturalPersonRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _naturalPersonRepository = naturalPersonRepository;
            _mapper = mapper;
        }

        public async Task<CreateNaturalPersonResponse> Handle(CreateNaturalPersonRequest request,
            CancellationToken cancellationToken)
        {
            NaturalPerson naturalPerson = _mapper.Map<NaturalPerson>(request);
            _naturalPersonRepository.Create(naturalPerson);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CreateNaturalPersonResponse>(naturalPerson);
        }
    }
}

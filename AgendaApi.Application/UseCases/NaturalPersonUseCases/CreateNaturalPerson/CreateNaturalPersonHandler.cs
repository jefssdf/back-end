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
        private readonly IMapper _mapper;

        public CreateNaturalPersonHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CreateNaturalPersonResponse> Handle(CreateNaturalPersonRequest request,
            CancellationToken cancellationToken)
        {
            NaturalPerson naturalPerson = _mapper.Map<NaturalPerson>(request);
            _unitOfWork.NaturalPersonRepository.Create(naturalPerson);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CreateNaturalPersonResponse>(naturalPerson);
        }
    }
}

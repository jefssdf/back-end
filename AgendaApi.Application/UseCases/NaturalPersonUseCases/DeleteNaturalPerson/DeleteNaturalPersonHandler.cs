using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.DeleteNaturalPerson
{
    public sealed class DeleteNaturalPersonHandler 
        : IRequestHandler<DeleteNaturalPersonRequest, DeleteNaturalPersonResponse>
    {
        private readonly INaturalPersonRepository _naturalPersonRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteNaturalPersonHandler(INaturalPersonRepository naturalPersonRepository, 
            IUnitOfWork unitOfWork, IMapper mapper)
        {
            _naturalPersonRepository = naturalPersonRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<DeleteNaturalPersonResponse> Handle(DeleteNaturalPersonRequest request,
            CancellationToken cancellationToken)
        {
            var naturalPerson = await _naturalPersonRepository.GetById(request.id, cancellationToken);
            
            if (naturalPerson == null) return default;

            _naturalPersonRepository.Delete(naturalPerson);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<DeleteNaturalPersonResponse>(naturalPerson);
        }
    }
}

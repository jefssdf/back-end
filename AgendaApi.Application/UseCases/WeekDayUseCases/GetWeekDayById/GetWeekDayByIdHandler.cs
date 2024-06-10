using AgendaApi.Application.UseCases.SchedulingUseCases.DTOs;
using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;
using System.Data;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.GetWeekDayById
{
    public sealed class GetWeekDayByIdHandler
        : IRequestHandler<GetWeekDayByIdRequest, GetWeekDayByIdResponseComplete>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetWeekDayByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<GetWeekDayByIdResponseComplete> Handle(GetWeekDayByIdRequest request,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

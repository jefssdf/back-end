﻿using MediatR;

namespace AgendaApi.Application.UseCases.ScheduleUseCases.GetBlockScheduleInfo
{
    public sealed record GetBlockScheduleInfoRequest(Guid legalEntityId) 
        : IRequest<GetBlockScheduleInfoResponse>;
}

using AgendaApi.Application.UseCases.ScheduleUseCases.GetBlockScheduleInfo;
using AgendaApi.Application.UseCases.ScheduleUseCases.GetMonthSchedule;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApi.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ScheduleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{legalEntityId:Guid}")]
        public async Task<ActionResult<FreeMonthScheduleResponse>> GetMonthSchedule(Guid? legalEntityId, DateTime? date, CancellationToken cancellationToken)
        {
            if (date is null) date = DateTime.UtcNow;
            if (legalEntityId is null) return BadRequest("Um identificador de pessoa juridica é necessário.");
            var result = await _mediator.Send(new GetMonthScheduleRequest(date.Value, legalEntityId.Value), cancellationToken);
            return Ok(result);
        }

        [HttpGet("blockService/{legalEntityId:Guid}")]
        public async Task<ActionResult<GetBlockScheduleInfoResponse>> GetBlockScheduleInfo(Guid legalEntityId, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetBlockScheduleInfoRequest(legalEntityId), cancellationToken);
            return Ok(result);
        }
    }
}

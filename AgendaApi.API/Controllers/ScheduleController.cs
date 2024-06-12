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

        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<GetMonthScheduleResponse>> GetMonthSchedule(Guid? id, DateTime? date, CancellationToken cancellationToken)
        {
            if (date is null) date = DateTime.UtcNow;
            var result = await _mediator.Send(new GetMonthScheduleRequest(date.Value, id.Value), cancellationToken);
            return Ok(result);
        }
    }
}

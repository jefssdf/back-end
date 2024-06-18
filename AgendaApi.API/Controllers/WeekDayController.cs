using AgendaApi.Application.UseCases.WeekDayUseCases.CreateWeekDay;
using AgendaApi.Application.UseCases.WeekDayUseCases.DeleteWeekDay;
using AgendaApi.Application.UseCases.WeekDayUseCases.GetAllWeekDay;
using AgendaApi.Application.UseCases.WeekDayUseCases.GetWeekDayById;
using AgendaApi.Application.UseCases.WeekDayUseCases.UpdateWeekDay;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApi.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WeekDayController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WeekDayController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("LegalEntityWeekDays{legalEntityId:Guid}")]
        public async Task<ActionResult<List<GetAllWeekDayResponse>>>
            GetAll(Guid? legalEntityId, CancellationToken cancellationToken)
        {
            if (legalEntityId is null) return BadRequest();
            var result = await _mediator.Send(new GetAllWeekDayRequest(legalEntityId.Value), cancellationToken);
            return Ok(result);
        }

        [HttpGet("{weekDayId:int}")]
        public async Task<ActionResult<GetWeekDayByIdResponse>> 
            GetById(int? weekDayId, CancellationToken cancellationToken)
        {
            if (weekDayId == null) return BadRequest();
            var result = await _mediator.Send(new GetWeekDayByIdRequest(weekDayId.Value), cancellationToken);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<CreateWeekDayResponse>> 
            Create(CreateWeekDayRequest request, CancellationToken cancellationToken)
        {
            if (request is null) return BadRequest();
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }

        [HttpPut("{weekDayId:int}")]
        public async Task<ActionResult<UpdateWeekDayResponse>> 
            Update(int weekDayId, UpdateWeekDayRequest request, CancellationToken cancellationToken)
        {
            if (weekDayId != request.id) return BadRequest();
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }

        [HttpDelete("{weekDayId:int}")]
        public async Task<ActionResult<DeleteWeekDayResponse>> 
            Delete(int? weekDayId, CancellationToken cancellationToken)
        {
            if (weekDayId == null) return BadRequest();
            var result = await _mediator.Send(new DeleteWeekDayRequest(weekDayId.Value), cancellationToken);
            return Ok(result);
        }
    }
}

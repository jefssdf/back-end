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

        [HttpGet("/LegalEntityWeekDays{legalEntityId:Guid}")]
        public async Task<ActionResult<List<GetAllWeekDayResponse>>>
            GetAll(Guid? legalEntityId, CancellationToken cancellationToken)
        {
            if (legalEntityId is null) return BadRequest();
            var result = await _mediator.Send(new GetAllWeekDayRequest(legalEntityId.Value), cancellationToken);
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<GetWeekDayByIdResponse>> 
            GetById(int id, CancellationToken cancellationToken)
        {
            if (id == null) return BadRequest();
            var result = await _mediator.Send(new GetWeekDayByIdRequest(id), cancellationToken);
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

        [HttpPut("{id:int}")]
        public async Task<ActionResult<UpdateWeekDayResponse>> 
            Update(int id, UpdateWeekDayRequest request, CancellationToken cancellationToken)
        {
            if (id != request.id) return BadRequest();
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<DeleteWeekDayResponse>> 
            Delete(int id, CancellationToken cancellationToken)
        {
            if (id == null) return BadRequest();
            var result = await _mediator.Send(new DeleteWeekDayRequest(id), cancellationToken);
            return Ok(result);
        }
    }
}

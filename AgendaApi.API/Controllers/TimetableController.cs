using AgendaApi.Application.UseCases.TimetableUseCases.CreateTimetable;
using AgendaApi.Application.UseCases.TimetableUseCases.DeleteTimetable;
using AgendaApi.Application.UseCases.TimetableUseCases.GetAllTimetables;
using AgendaApi.Application.UseCases.TimetableUseCases.UpdateTimetable;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApi.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TimetableController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TimetableController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllTimetablesResponse>>> 
            GetAll(CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllTimetablesRequest(), cancellationToken);
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<List<CreateTimetableResponse>>> 
            Create(CreateMultipleTimetableRequest request, CancellationToken cancellationToken)
        {
            if (request is null) return BadRequest();
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }
        [HttpPut("{id:Guid}")]
        public async Task<ActionResult<UpdateTimetableResponse>> 
            Update(Guid id, UpdateTimetableRequest request, CancellationToken cancellationToken)
        {
            if (id != request.id) return BadRequest();
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }
        [HttpDelete]
        public async Task<ActionResult<DeleteTimetableResponse>> 
            Delete(CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new DeleteTimetableRequest(), cancellationToken);
            return Ok(result);
        }
    }
}

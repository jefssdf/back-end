using AgendaApi.Application.UseCases.SchedulingStatusUseCase.GetSchedulingStatusById;
using AgendaApi.Application.UseCases.SchedulingUseCases.ConfirmeScheduling;
using AgendaApi.Application.UseCases.SchedulingUseCases.CreateScheduling;
using AgendaApi.Application.UseCases.SchedulingUseCases.DeleteScheduling;
using AgendaApi.Application.UseCases.SchedulingUseCases.GetAllScheduling;
using AgendaApi.Application.UseCases.SchedulingUseCases.GetAllSchedulingByLegalEntity;
using AgendaApi.Application.UseCases.SchedulingUseCases.GetAllSchedulingByNaturalPerson;
using AgendaApi.Application.UseCases.SchedulingUseCases.GetSchedulingById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApi.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SchedulingController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SchedulingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllSchedulingResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllSchedulingRequest(), cancellationToken);
            return Ok(result);
        }

        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<GetSchedulingByIdResponse>> GetById(Guid? id, CancellationToken cancellationToken)
        {
            if (id is null) return BadRequest();
            var result = await _mediator.Send(new GetSchedulingByIdRequest(id.Value), cancellationToken);
            return Ok(result);
        }

        [HttpGet("/legalEntity/{id:Guid}")]
        public async Task<ActionResult<List<GetAllSchedulingByLegalEntityResponse>>>
            GetAllByLegalEntity(Guid? id, CancellationToken cancellationToken)
        {
            if (id is null) return BadRequest();
            var result = await _mediator.Send(new GetAllSchedulingByLegalEntityRequest(id.Value), cancellationToken);
            return Ok(result);
        }

        [HttpGet("/naturalPerson/{id:Guid}")]
        public async Task<ActionResult<List<GetAllSchedulingByNaturalPersonResponse>>>
            GetAllByNaturalPerson(Guid? id, CancellationToken cancellationToken)
        {
            if (id is null) return BadRequest();
            var result = await _mediator.Send(new GetAllSchedulingByNaturalPersonRequest(id.Value), cancellationToken);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<CreateSchedulingResponse>> Create(CreateSchedulingRequest request,
            CancellationToken cancellationToken)
        {
            if (request is null) return BadRequest();
            try
            {
                var result = await _mediator.Send(request, cancellationToken);
                return Ok(result);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("/confirme/{id:Guid}")]
        public async Task<ActionResult<ConfirmeSchedulingResponse>> Confirme(Guid? id,
            CancellationToken cancellationToken)
        {
            if (id is null) return BadRequest();
            var result = await _mediator.Send(new ConfirmeSchedulingRequest(id.Value), cancellationToken);
            return Ok(result);
        }

        [HttpPut("/cancel/{id:Guid}")]
        public async Task<ActionResult<CancelSchedulingResponse>> Cancel(Guid id, CancelSchedulingRequest request,
            CancellationToken cancellationToken)
        {
            if (request.schedulingId != id) return BadRequest();
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }
    }
}

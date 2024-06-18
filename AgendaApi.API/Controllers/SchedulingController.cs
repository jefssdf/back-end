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

        [HttpGet("{schedulingId:Guid}")]
        public async Task<ActionResult<GetSchedulingByIdResponse>> GetById(Guid? schedulingId, CancellationToken cancellationToken)
        {
            if (schedulingId is null) return BadRequest();
            var result = await _mediator.Send(new GetSchedulingByIdRequest(schedulingId.Value), cancellationToken);
            return Ok(result);
        }

        [HttpGet("legalEntity/{legalEntityId:Guid}")]
        public async Task<ActionResult<List<GetAllSchedulingByLegalEntityResponse>>>
            GetAllByLegalEntity(Guid? legalEntityId, CancellationToken cancellationToken)
        {
            if (legalEntityId is null) return BadRequest();
            var result = await _mediator.Send(new GetAllSchedulingByLegalEntityRequest(legalEntityId.Value), cancellationToken);
            return Ok(result);
        }

        [HttpGet("naturalPerson/{naturalPersonId:Guid}")]
        public async Task<ActionResult<List<GetAllSchedulingByNaturalPersonResponse>>>
            GetAllByNaturalPerson(Guid? naturalPersonId, CancellationToken cancellationToken)
        {
            if (naturalPersonId is null) return BadRequest();
            var result = await _mediator.Send(new GetAllSchedulingByNaturalPersonRequest(naturalPersonId.Value), cancellationToken);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<CreateSchedulingResponse>> Create(CreateSchedulingRequest request,
            CancellationToken cancellationToken)
        {
            if (request is null) return BadRequest();
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }

        [HttpPut("ends/{schedulingId:Guid}")]
        public async Task<ActionResult<EndsSchedulingResponse>> Confirme(Guid? schedulingId,
            CancellationToken cancellationToken)
        {
            if (schedulingId is null) return BadRequest();
            var result = await _mediator.Send(new EndsSchedulingRequest(schedulingId.Value), cancellationToken);
            return Ok(result);
        }

        [HttpPut("cancel/{schedulingId:Guid}")]
        public async Task<ActionResult<CancelSchedulingResponse>> Cancel(Guid? schedulingId, CancelSchedulingRequest request,
            CancellationToken cancellationToken)
        {
            if (request.schedulingId != schedulingId) return BadRequest();
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }
    }
}

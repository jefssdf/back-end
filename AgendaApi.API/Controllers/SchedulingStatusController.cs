using AgendaApi.Application.UseCases.SchedulingStatusUseCase.CreateSchedulingStatus;
using AgendaApi.Application.UseCases.SchedulingStatusUseCase.GetAllSchedulingStatus;
using AgendaApi.Application.UseCases.SchedulingStatusUseCase.GetSchedulingStatusById;
using AgendaApi.Application.UseCases.SchedulingStatusUseCase.UpdateSchedulingStatus;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApi.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SchedulingStatusController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SchedulingStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<GetAllSchedulingStatusResponse>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllSchedulingStatusRequest(), cancellationToken);
            return Ok(result);
        }

        [HttpGet("{schedulingStatusId:int}")]
        public async Task<ActionResult<GetSchedulingStatusByIdResponse>> GetById(int? schedulingStatusId,
            CancellationToken cancellationToken)
        {
            if (schedulingStatusId == null) return BadRequest();

            var result = await _mediator.Send(new GetSchedulingStatusByIdRequest(schedulingStatusId.Value), cancellationToken);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<CreateSchedulingStatusResponse>> Create(CreateSchedulingStatusRequest request,
                     CancellationToken cancellationToken)
        {
            if (request is null) return BadRequest();

            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }

        [HttpPut("{schedulingStatusId:int}")]
        public async Task<ActionResult<UpdateSchedulingStatusResponse>> Update(int schedulingStatusId, UpdateSchedulingStatusRequest request,
            CancellationToken cancellationToken)
        {
            if (request.schedulingStatusId != schedulingStatusId) return BadRequest();

            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }
    }
}

using AgendaApi.Application.UseCases.CancellationUseCase.GetAllCancellation;
using AgendaApi.Application.UseCases.CancellationUseCase.GetAllCancellationByOwner;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApi.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CancellationController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CancellationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,PJ,PF")]
        public async Task<ActionResult<GetAllCancellationResponse>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllCancellationRequest(), cancellationToken);
            return Ok(result);
        }

        [HttpGet("{cancellationId:Guid}")]
        [Authorize(Roles = "Admin,PJ,PF")]
        public async Task<ActionResult<GetAllCancellationByOwnerRequest>> GetAllByOwner(Guid? cancellationId, 
            CancellationToken cancellationToken)
        {
            if (cancellationId is null) return BadRequest();

            var result = await _mediator.Send(new GetAllCancellationByOwnerRequest(cancellationId.Value), cancellationToken);
            return Ok(result);
        }
    }
}

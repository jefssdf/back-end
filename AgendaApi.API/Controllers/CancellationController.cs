using AgendaApi.Application.UseCases.CancellationUseCase.GetAllCancellation;
using AgendaApi.Application.UseCases.CancellationUseCase.GetAllCancellationByOwner;
using MediatR;
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
        public async Task<ActionResult<GetAllCancellationResponse>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllCancellationRequest(), cancellationToken);
            return Ok(result);
        }

        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<GetAllCancellationByOwnerRequest>> GetAllByOwner(Guid? id, 
            CancellationToken cancellationToken)
        {
            if (id is null) return BadRequest();

            var result = await _mediator.Send(new GetAllCancellationByOwnerRequest(id.Value), cancellationToken);
            return Ok(result);
        }
    }
}

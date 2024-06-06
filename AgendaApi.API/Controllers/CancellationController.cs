using AgendaApi.Application.UseCases.CancellationUseCase.CreateCancellation;
using AgendaApi.Application.UseCases.CancellationUseCase.DeleteCancellation;
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

        [HttpPost]
        public async Task<ActionResult<CreateCancellationResponse>> Create(CreateCancellationRequest request,
            CancellationToken cancellationToken)
        {
            if (request is null) return BadRequest();

            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<DeleteCancellationResponse>> Delete(Guid? id,
            CancellationToken cancellationToken)
        {
            if (id is null) return BadRequest();

            var result = await _mediator.Send(new DeleteCancellationRequest(id.Value), cancellationToken);
            return Ok(result);
        }
    }
}

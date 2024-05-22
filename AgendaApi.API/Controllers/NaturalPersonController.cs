using AgendaApi.Application.UseCases.NaturalPersonUseCases.CreateNaturalPerson;
using AgendaApi.Application.UseCases.NaturalPersonUseCases.DeleteNaturalPerson;
using AgendaApi.Application.UseCases.NaturalPersonUseCases.GetAllNaturalPerson;
using AgendaApi.Application.UseCases.NaturalPersonUseCases.GetNaturalPersonByEmail;
using AgendaApi.Application.UseCases.NaturalPersonUseCases.UpdateNaturalPerson;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NaturalPersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NaturalPersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllNaturalPersonResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllNaturalPersonRequest(), cancellationToken);
            return Ok(result);
        }

        [HttpGet("{email}")]
        public async Task<ActionResult<GetNaturalPersonByEmailResponse>> GetByEmail(string email,
            CancellationToken cancellationToken)
        {
            if (email is null) return BadRequest();
            var result = await _mediator.Send(new GetNaturalPersonByEmailRequest(email), cancellationToken);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<CreateNaturalPersonResponse>> Create(CreateNaturalPersonRequest request,
            CancellationToken cancellationToken)
        {
            if (request is null) return BadRequest();
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }

        [HttpPut("{id:Guid}")]
        public async Task<ActionResult<UpdateNaturalPersonResponse>> Update(Guid id, UpdateNaturalPersonRequest request,
            CancellationToken cancellationToken)
        {
            if (id != request.id) return BadRequest();
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<DeleteNaturalPersonResponse>> Delete(Guid? id,
            CancellationToken cancellationToken)
        {
            if (id is null) return BadRequest();
            var result = await _mediator.Send(new DeleteNaturalPersonRequest(id.Value), cancellationToken);
            return Ok(result);
        }
    }
}

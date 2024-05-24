using AgendaApi.Application.UseCases.ServiceCategoryUseCase.GetAllServiceCategory;
using AgendaApi.Application.UseCases.ServiceUseCase.CreateService;
using AgendaApi.Application.UseCases.ServiceUseCase.DeleteService;
using AgendaApi.Application.UseCases.ServiceUseCase.GetServiceById;
using AgendaApi.Application.UseCases.ServiceUseCase.UpdateService;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApi.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllServiceCategoryResponse>>> 
            GetAll(CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllServiceCategoryRequest(), cancellationToken);
            return Ok(result);
        }

        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<GetServiceByIdResponse>> GetById(Guid? id,
            CancellationToken cancellationToken)
        {
            if (id is null) return BadRequest();
            var result = await _mediator.Send(new GetServiceByIdRequest(id.Value), cancellationToken);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<CreateServiceResponse>> Create(CreateServiceRequest request,
            CancellationToken cancellationToken)
        {
            if (request is null) return BadRequest();
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }

        [HttpPut("{id:Guid}")]
        public async Task<ActionResult<UpdateServiceResponse>> Update(Guid id,
            UpdateServiceRequest request, CancellationToken cancellationToken)
        {
            if (id != request.id) return BadRequest();
            var result = _mediator.Send(request, cancellationToken);
            return Ok(result);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<DeleteServiceResponse>> Delete(Guid? id,
            CancellationToken cancellationToken)
        {
            if (id is null) return BadRequest();
            var result = await _mediator.Send(new DeleteServiceRequest(id.Value), cancellationToken);
            return Ok(result);
        }
    }
}

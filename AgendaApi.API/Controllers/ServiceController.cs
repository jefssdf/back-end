﻿using AgendaApi.Application.UseCases.ServiceCategoryUseCase.GetAllServiceCategory;
using AgendaApi.Application.UseCases.ServiceUseCase.CreateService;
using AgendaApi.Application.UseCases.ServiceUseCase.DeleteService;
using AgendaApi.Application.UseCases.ServiceUseCase.GetAllService;
using AgendaApi.Application.UseCases.ServiceUseCase.GetServiceById;
using AgendaApi.Application.UseCases.ServiceUseCase.UpdateService;
using AgendaApi.Persistence.Context;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgendaApi.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly AgendaApiDbContext _dbContext;

        public ServiceController(IMediator mediator, AgendaApiDbContext context)
        {
            _mediator = mediator;
            _dbContext = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllServiceResponse>>> 
            GetAll(CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllServiceRequest(), cancellationToken);
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
            var result = await _mediator.Send(request, cancellationToken);
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
﻿using MediatR;
using MediatRDemo.Med.Commands;
using MediatRDemo.Med.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatRDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdcutsController : ControllerBase
    {
        private readonly IMediator mediator;
        public ProdcutsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var query=new GetProductByIdQuery() { Id= id };
            return Ok(await mediator.Send(query));
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllProductQuery();
            return Ok(await mediator.Send(query));
        }


        [HttpPost()]
        public async Task<IActionResult> CreateProduct(CreateProductCommand command)
        {
           
            return Ok(await mediator.Send(command));
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.Commands.CreateProduct;
using Application.Features.Queries.GetAllProduct;
using Application.Features.Queries.GetByIdProduct;
using Application.Features.Queries.GetWhereProduct;
using MediatR;

namespace ProductEx.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //private readonly GetAllProductQueryHandler _getAllProductQueryHandler;
        //private readonly GetByIdProductQueryHandler _getByIdProductQueryHandler;
        //private readonly GetWhereProductQueryHandler _getWhereProductQueryHandler;
        //private readonly CreateProductCommandHandler _createProductCommandHandler;

        //public ProductsController(GetAllProductQueryHandler getAllProductQueryHandler, GetByIdProductQueryHandler getByIdProductQueryHandler, GetWhereProductQueryHandler getWhereProductQueryHandler, CreateProductCommandHandler createProductCommandHandler)
        //{
        //    _getAllProductQueryHandler = getAllProductQueryHandler;
        //    _getByIdProductQueryHandler = getByIdProductQueryHandler;
        //    _getWhereProductQueryHandler = getWhereProductQueryHandler;
        //    _createProductCommandHandler = createProductCommandHandler;
        //}

        private readonly IMediator _mediator;
        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<List<GetAllProductQueryResponse>> GetAll()
        {
            //return await _getAllProductQueryHandler.GetAllProduct(new GetAllProductQueryRequest());
            var response = await _mediator.Send(new GetAllProductQueryRequest());
            return response;
        }

        [HttpGet("{id}")]
        public async Task<GetByIdProductQueryResponse> GetById(int id)
        {
            //return await _getByIdProductQueryHandler.GetByIdProduct(new GetByIdProductQueryRequest{Id = id});
            return await _mediator.Send(new GetByIdProductQueryRequest { Id = id });
        }

        [HttpGet("search/{name}")]
        public async Task<List<GetWhereProductQueryResponse>> GetName([FromQuery] GetWhereProductQueryRequest request)
        {
            //return await _getWhereProductQueryHandler.GetWhereProduct(request);
            return await _mediator.Send(request);
        }

        [HttpPost]
        public async Task<CreateProductCommandResponse> Post([FromBody] CreateProductCommandRequest request)
        {
            //return await _createProductCommandHandler.CreateProduct(request);
            return await _mediator.Send(request);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.Queries.GetAllProduct
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
    {
        private readonly IProductRepository _productRepository;
        private IMapper _mapper;

        public GetAllProductQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //public async Task<List<GetAllProductQueryResponse>> GetAllProduct(GetAllProductQueryRequest request)
        //{
        //    var product = await _productRepository.GetAsync(x => x.Id > 0);

        //    return product.Select(p => new GetAllProductQueryResponse
        //    {
        //        Id = p.Id,
        //        Name = p.Name,
        //        Quantity = p.Quantity
        //    }).ToList();
        //}

        public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetAsync(x => x.Id > 0);
            return _mapper.Map<List<GetAllProductQueryResponse>>(product);

            //return product.Select(p => new GetAllProductQueryResponse
            //{
            //    Id = p.Id,
            //    Name = p.Name,
            //    Quantity = p.Quantity
            //}).ToList();
        }
    }
}

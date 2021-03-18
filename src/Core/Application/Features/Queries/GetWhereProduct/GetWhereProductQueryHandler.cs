using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Features.Queries.GetByIdProduct;
using Application.Interfaces.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.Queries.GetWhereProduct
{
    public class GetWhereProductQueryHandler : IRequestHandler<GetWhereProductQueryRequest, List<GetWhereProductQueryResponse>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public GetWhereProductQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        //public async Task<List<GetWhereProductQueryResponse>> GetWhereProduct(GetWhereProductQueryRequest request)
        //{
        //    var product = await _productRepository.GetAsync(x => x.Name == request.Name);

        //    return product.Select(p => new GetWhereProductQueryResponse
        //    {
        //        Id = p.Id,
        //        Name = p.Name,
        //        Quantity = p.Quantity
        //    }).ToList();
        //}

        public async Task<List<GetWhereProductQueryResponse>> Handle(GetWhereProductQueryRequest request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetAsync(x => x.Name == request.Name);
            return _mapper.Map<List<GetWhereProductQueryResponse>>(product);

            //return product.Select(p => new GetWhereProductQueryResponse
            //{
            //    Id = p.Id,
            //    Name = p.Name,
            //    Quantity = p.Quantity
            //}).ToList();
        }
    }
}

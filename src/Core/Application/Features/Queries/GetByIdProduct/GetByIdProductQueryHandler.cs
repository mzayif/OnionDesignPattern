using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Features.Queries.GetAllProduct;
using Application.Interfaces.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.Queries.GetByIdProduct
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {
        private readonly IProductRepository _productRepository;
        private IMapper _mapper;

        public GetByIdProductQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        //public async Task<GetByIdProductQueryResponse> GetByIdProduct(GetByIdProductQueryRequest request)
        //{
        //    var product = await _productRepository.GetByIdAsync(request.Id);

        //    return new GetByIdProductQueryResponse
        //    {
        //        Id = product.Id,
        //        Name = product.Name,
        //        Quantity = product.Quantity
        //    };
        //}

        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);
            return _mapper.Map<GetByIdProductQueryResponse>(product);

            //return new GetByIdProductQueryResponse
            //{
            //    Id = product.Id,
            //    Name = product.Name,
            //    Quantity = product.Quantity
            //};
        }
    }
}

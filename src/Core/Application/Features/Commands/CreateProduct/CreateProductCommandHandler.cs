using System.Threading;
using System.Threading.Tasks;
using Application.Features.Queries.GetAllProduct;
using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        private readonly IProductRepository _productRepository;

        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //public async Task<CreateProductCommandResponse> CreateProduct(CreateProductCommandRequest request)
        //{
        //    var product = new Product
        //    {
        //        Name = request.Name,
        //        Price = request.Price,
        //        Quantity = request.Quantity,
        //        StockCount = request.StockCount
        //    };

        //    await _productRepository.AddAsync(product);

        //    return new CreateProductCommandResponse { Success = true };
        //}

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {

            var product = new Product
            {
                Name = request.Name,
                Price = request.Price,
                Quantity = request.Quantity,
                StockCount = request.StockCount
            };

            await _productRepository.AddAsync(product);

            return new CreateProductCommandResponse { Success = true };
        }
    }
}

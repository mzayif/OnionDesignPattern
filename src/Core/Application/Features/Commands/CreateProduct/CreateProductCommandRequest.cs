using MediatR;

namespace Application.Features.Commands.CreateProduct
{
    public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int StockCount { get; set; }
    }
}

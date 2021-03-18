using MediatR;

namespace Application.Features.Queries.GetByIdProduct
{
    public class GetByIdProductQueryRequest : IRequest<GetByIdProductQueryResponse>
    {
        public int Id { get; set; }
    }
}

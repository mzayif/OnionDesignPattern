using System.Collections.Generic;
using MediatR;

namespace Application.Features.Queries.GetWhereProduct
{
    public class GetWhereProductQueryRequest : IRequest<List<GetWhereProductQueryResponse>>
    {
        public string Name { get; set; }
    }
}

using MediatR;
using Ordering.Application.Response;
using System.Collections.Generic;

namespace Ordering.Application.Queries
{
    public class GetOrderBySellerUserNameQuery:IRequest<IEnumerable<OrderResponse>>
    {
        public string UserName { get; set; }
        public GetOrderBySellerUserNameQuery(string userName)
        {
            UserName = userName;
        }
    }
}

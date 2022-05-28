using MediatR;

namespace Ordering.Application.Features.Orders.Queries.GetOrdersList
{
    public class GetOrdersListQuery: IRequest<List<OrdersVm>>
    {
        public string Username { get; set; } = string.Empty;

        public GetOrdersListQuery(String username)
        {
            this.Username = username;
        }
    }
}

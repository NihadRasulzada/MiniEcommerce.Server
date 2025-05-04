using Microsoft.AspNetCore.SignalR;
using MiniEcommerceServer.Application.Abstractions.Hubs;
using MiniEcommerceServer.SignalR.Hubs;

namespace MiniEcommerceServer.SignalR.HubServices
{
    public class OrderHubService : IOrderHubService
    {
        readonly IHubContext<OrderHub> _hubContext;

        public OrderHubService(IHubContext<OrderHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task OrderAddedMessageAsync(string message)
            => await _hubContext.Clients.All.SendAsync(ReceiveFunctionNames.OrderAddedMessage, message);
    }
}

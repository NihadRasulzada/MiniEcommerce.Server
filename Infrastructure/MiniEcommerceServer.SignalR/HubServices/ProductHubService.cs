using Microsoft.AspNetCore.SignalR;
using MiniEcommerceServer.Application.Abstractions.Hubs;
using MiniEcommerceServer.SignalR.Hubs;

namespace MiniEcommerceServer.SignalR.HubServices
{
    public class ProductHubService : IProductHubService
    {
        readonly IHubContext<ProductHub> _hubContext;
        public ProductHubService(IHubContext<ProductHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task ProductAddedMessageAsync(string message)
        {
            await _hubContext.Clients.All.SendAsync(ReceiveFunctionNames.ProductAddedMessage, message);
        }
    }
}

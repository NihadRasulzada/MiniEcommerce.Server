using Microsoft.AspNetCore.SignalR;
using MiniEcommerceServer.Application.Abstractions.Hubs;

namespace MiniEcommerceServer.SignalR.HubServices
{
    public class ProductHubService : IProductHubService
    {
        readonly IHubContext _hubContext;
        public ProductHubService(IHubContext hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task ProductAddedMessageAsync(string message)
        {
            await _hubContext.Clients.All.SendAsync(ReceiveFunctionNames.ProductAddedMessage, message);
        }
    }
}

using Microsoft.AspNetCore.Builder;
using MiniEcommerceServer.SignalR.Hubs;

namespace MiniEcommerceServer.SignalR
{
    public static class HubRegistration
    {
        public static void MapHubs(this WebApplication application)
        {
            application.MapHub<ProductHub>("/products-hub");
        }
    }
}

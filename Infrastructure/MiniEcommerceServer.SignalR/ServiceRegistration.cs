﻿using Microsoft.Extensions.DependencyInjection;
using MiniEcommerceServer.Application.Abstractions.Hubs;
using MiniEcommerceServer.SignalR.HubServices;

namespace MiniEcommerceServer.SignalR
{
    public static class ServiceRegistration
    {
        public static void AddSignalRServices(this IServiceCollection services)
        {
            services.AddSignalR();
            services.AddTransient<IProductHubService, ProductHubService>();
            services.AddTransient<IOrderHubService, OrderHubService>();
        }
    }
}

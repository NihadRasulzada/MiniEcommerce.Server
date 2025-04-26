using Microsoft.Extensions.DependencyInjection;
using MiniEcommerceServer.Application.Abstractions.Storage;
using MiniEcommerceServer.Application.Abstractions.Token;
using MiniEcommerceServer.Infrastructure.Enums;
using MiniEcommerceServer.Infrastructure.Services.Storage;
using MiniEcommerceServer.Infrastructure.Services.Storage.Azure;
using MiniEcommerceServer.Infrastructure.Services.Storage.Local;
using MiniEcommerceServer.Infrastructure.Services.Token;

namespace MiniEcommerceServer.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IStorageService, StorageService>();
            services.AddScoped<ITokenHandler, TokenHandler>();
        }
        public static void AddStorage<T>(this IServiceCollection services) where T : Storage, IStorage
        {
            services.AddScoped<IStorage, T>();
        }
        public static void AddStorage(this IServiceCollection serviceCollection, StorageType storageType)
        {
            switch (storageType)
            {
                case StorageType.Local:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
                case StorageType.Azure:
                    serviceCollection.AddScoped<IStorage, AzureStorage>();
                    break;
                case StorageType.AWS:

                    break;
                default:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
            }
        }
    }
}

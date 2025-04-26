using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MiniEcommerceServer.Application.Repositories.CustomerRepositories;
using MiniEcommerceServer.Application.Repositories.OrderRepositories;
using MiniEcommerceServer.Application.Repositories.ProductRepositories;
using MiniEcommerceServer.Domain.Entities.Identity;
using MiniEcommerceServer.Persistence.Contexts;
using MiniEcommerceServer.Persistence.Repositories.CustomerRepositories;
using MiniEcommerceServer.Persistence.Repositories.OrderRepositories;
using MiniEcommerceServer.Persistence.Repositories.ProductRepositories;

namespace MiniEcommerceServer.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ECommerceAPIContext>(options => options.UseNpgsql(Configuration.ConnectionString));

            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<ECommerceAPIContext>();

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MiniEcommerceServer.Application.Abstractions.Services;
using MiniEcommerceServer.Application.Abstractions.Services.Authentications;
using MiniEcommerceServer.Application.Repositories.CustomerRepositories;
using MiniEcommerceServer.Application.Repositories.FileRepositories;
using MiniEcommerceServer.Application.Repositories.InvoiceFileRepositories;
using MiniEcommerceServer.Application.Repositories.OrderRepositories;
using MiniEcommerceServer.Application.Repositories.ProductImageFileRepositories;
using MiniEcommerceServer.Application.Repositories.ProductRepositories;
using MiniEcommerceServer.Domain.Entities.Identity;
using MiniEcommerceServer.Persistence.Contexts;
using MiniEcommerceServer.Persistence.Repositories.CustomerRepositories;
using MiniEcommerceServer.Persistence.Repositories.FileRepositories;
using MiniEcommerceServer.Persistence.Repositories.InvoiceFileRepositories;
using MiniEcommerceServer.Persistence.Repositories.OrderRepositories;
using MiniEcommerceServer.Persistence.Repositories.ProductImageFileRepositories;
using MiniEcommerceServer.Persistence.Repositories.ProductRepositories;
using MiniEcommerceServer.Persistence.Services;

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
            services.AddScoped<IFileReadRepository, FileReadRepositories>();
            services.AddScoped<IFileWriteRepository, FileWriteRepositories>();
            services.AddScoped<IProductImageFileReadRepository, ProductImageFileReadRepository>();
            services.AddScoped<IProductImageFileWriteRepository, ProductImageFileWriteRepository>();
            services.AddScoped<IInvoiceFileReadRepository, InvoiceFileReadRepository>();
            services.AddScoped<IInvoiceFileWriteRepository, InvoiceFileWriteRepository>();


            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IExternalAuthentication, AuthService>();
            services.AddScoped<IInternalAuthentication, AuthService>();
        }
    }
}

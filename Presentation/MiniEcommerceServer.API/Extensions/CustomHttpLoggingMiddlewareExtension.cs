using MiniEcommerceServer.API.Middlewares;

namespace MiniEcommerceServer.API.Extensions
{
    public static class CustomHttpLoggingMiddlewareExtension
    {
        public static IApplicationBuilder UseCustomHttpLogging(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomHttpLoggingMiddleware>();
        }
    }
}

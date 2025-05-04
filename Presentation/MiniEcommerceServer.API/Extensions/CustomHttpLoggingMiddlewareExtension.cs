namespace MiniEcommerceServer.API.Extensions
{
    public static class CustomHttpLoggingMiddlewareExtension
    {
        public static IApplicationBuilder UseCustomHttpLogging(this WebApplication builder)
        {
            return builder.UseMiddleware<CustomHttpLoggingMiddleware>();
        }
    }
}

using System.Text.Json;

namespace MiniEcommerceServer.API.Middlewares
{
    public class CustomHttpLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<CustomHttpLoggingMiddleware> _logger;

        public CustomHttpLoggingMiddleware(RequestDelegate next, ILogger<CustomHttpLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Method == HttpMethods.Post ||
                context.Request.Method == HttpMethods.Get ||
                context.Request.Method == HttpMethods.Put ||
                context.Request.Method == HttpMethods.Delete)
            {
                context.Request.EnableBuffering();

                using var reader = new StreamReader(context.Request.Body, Encoding.UTF8, leaveOpen: true);
                var body = await reader.ReadToEndAsync();
                context.Request.Body.Position = 0;

                var maskedBody = MaskSensitiveFields(body);

                if (context.Request.Method == HttpMethods.Post)
                {
                    _logger.LogInformation("HTTP {Method} to {Path} with body: {Body}", context.Request.Method, context.Request.Path, maskedBody);
                }
                else if (context.Request.Method == HttpMethods.Get)
                {
                    _logger.LogInformation("HTTP {Method} to {Path}", context.Request.Method, context.Request.Path);
                }
                else if (context.Request.Method == HttpMethods.Put)
                {
                    _logger.LogInformation("HTTP {Method} to {Path} with body: {Body}", context.Request.Method, context.Request.Path, maskedBody);
                }
                else if (context.Request.Method == HttpMethods.Delete)
                {
                    _logger.LogInformation("HTTP {Method} to {Path}", context.Request.Method, context.Request.Path);
                }
            }

            await _next(context);
        }

        private string MaskSensitiveFields(string json)
        {
            var dict = JsonSerializer.Deserialize<Dictionary<string, object>>(json);
            if (dict == null) return json;

            var sensitiveFields = new[] { "password", "confirmPassword", "oldPassword", "newPassword" };

            foreach (var field in sensitiveFields)
            {
                if (dict.ContainsKey(field))
                {
                    dict[field] = "****";
                }
            }

            return JsonSerializer.Serialize(dict);
        }
    }
}

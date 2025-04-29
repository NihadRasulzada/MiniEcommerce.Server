using System.Net.Mime;
using System.Text;
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
            if (context.Request.Method == HttpMethods.Post &&
                context.Request.ContentType != null &&
                context.Request.ContentType.Contains(MediaTypeNames.Application.Json))
            {
                context.Request.EnableBuffering(); 

                using var reader = new StreamReader(context.Request.Body, Encoding.UTF8, leaveOpen: true);
                var body = await reader.ReadToEndAsync();
                context.Request.Body.Position = 0; 

                var maskedBody = MaskSensitiveFields(body);

                _logger.LogInformation("HTTP POST to {Path} with body: {Body}", context.Request.Path, maskedBody);
            }

            await _next(context);
        }

        private string MaskSensitiveFields(string json)
        {
            try
            {
                var dict = JsonSerializer.Deserialize<Dictionary<string, object>>(json);
                if (dict == null) return json;

                var sensitiveFields = new[] { "password", "confirmPassword", "oldPassword", "newPassword" };

                foreach (var field in sensitiveFields)
                {
                    if (dict.ContainsKey(field))
                        dict[field] = "****";
                }

                return JsonSerializer.Serialize(dict);
            }
            catch
            {
                return "[Invalid JSON]";
            }
        }
    }
}

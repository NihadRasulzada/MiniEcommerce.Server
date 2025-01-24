using Microsoft.Extensions.Configuration;

namespace MiniEcommerceServer.Persistence
{
    static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/MiniEcommerceServer.API"));
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("PostgreSQL");
            }
        }
    }
}

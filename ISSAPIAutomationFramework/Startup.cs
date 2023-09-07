using ISSAPIAutomationFramework.Base.Interfaces;
using ISSAPIAutomationFramework.Base;
using Microsoft.Extensions.DependencyInjection;

namespace ISSAPIAutomationFramework;
public class Startup
{
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IRestLibrary, RestLibrary>();
        services.AddScoped<IRestBuilder, RestBuilder>();
        services.AddScoped<IRestFactory, RestFactory>();
    }
}

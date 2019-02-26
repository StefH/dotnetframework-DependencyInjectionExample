using Microsoft.Extensions.DependencyInjection;
using System.Web.Http;

namespace WebApplicationWithDI.DI
{
    public class Startup
    {
        public static void Bootstrapper(HttpConfiguration config)
        {
            var services = InitServices();
            var provider = services.BuildServiceProvider();
            var resolver = new DefaultDependencyResolver(provider);

            config.DependencyResolver = resolver;
        }

        private static IServiceCollection InitServices()
        {
            var services = new ServiceCollection();

            services.AddControllersAsServices();

            services.AddSingleton<ITest, Test>();

            return services;
        }
    }
}
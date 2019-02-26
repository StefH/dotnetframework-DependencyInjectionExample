using System.Net.Http.Formatting;
using System.Web.Http;
using WebApplicationWithDI.DI;

namespace WebApplicationWithDI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // using Microsoft.Extension.DependencyInjection here.
            Startup.Bootstrapper(config);

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

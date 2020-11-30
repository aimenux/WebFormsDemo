using Microsoft.Extensions.DependencyInjection;
using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using WebApp3.DataAccess;
using WebApp3.Ioc;

namespace WebApp3
{
    public class Global : HttpApplication
    {
        public void Application_Start(object sender, EventArgs e)
        {
            ConfigureIoc();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private static void ConfigureIoc()
        {
            var collection = new ServiceCollection();
            collection.AddScoped<ISchoolDbContext, SchoolDbContext>();
            var serviceProvider = collection.BuildServiceProvider();
            HttpRuntime.WebObjectActivator = new ServiceCollectionProvider(serviceProvider);
        }
    }
}
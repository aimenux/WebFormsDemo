using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace WebApp1
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings
            {
                AutoRedirectMode = RedirectMode.Permanent
            };

            routes.EnableFriendlyUrls(settings);
            routes.MapPageRoute("HomePage", "", "~/Pages/HomePage.aspx");
            routes.MapPageRoute("WebPage", "{webpage}", "~/Pages/{webpage}.aspx");
        }
    }
}

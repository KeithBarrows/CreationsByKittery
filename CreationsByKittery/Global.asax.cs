using CreationsByKittery.App_Start;
using System.Net.NetworkInformation;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using CreationsByKittery.Features.Gallery;
using CreationsByKittery.Features.Home;
using MediatR;
using global::StructureMap;
using Sol3.IoC;

namespace CreationsByKittery
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public IMediator Mediator;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Set up for Features...
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new FeatureViewLocationRazorViewEngine());
        }
    }
}

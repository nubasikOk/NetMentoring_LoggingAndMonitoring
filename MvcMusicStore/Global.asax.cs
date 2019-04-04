using Logger.Infrastructure;
using MvcMusicStore.Perfomance;
using PerformanceCounterHelper;
using System.Configuration;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.WebPages;

namespace MvcMusicStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private ILogger logger;
        public MvcApplication()
        {
            if (ConfigurationManager.AppSettings["Logging"].AsBool())
            {
                logger = new Logger.Logger();
            }
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            using (var counterHelper = PerformanceHelper.CreateCounterHelper<Counters>("MvcMusicStore"))
            {
                counterHelper.RawValue(Counters.Login, 0);
            }
        }

        protected void Application_Error()
        {
            var error = Server.GetLastError();
            logger?.LogError(error, error.Message);
            logger?.LogError(error, error.Message);
        }
    }
}

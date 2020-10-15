using Store.Data;
using System.Web.Mvc;
using System.Web.Routing;

namespace Store.Presentation
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Init database and seed data for the project
            System.Data.Entity.Database.SetInitializer(new StoreSeedData());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}

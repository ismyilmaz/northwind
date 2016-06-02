using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Norhwind.Entities;
using Northwind.MVCWebUI.Infrastructure;
using Northwind.MVCWebUI.ModelBinders;

namespace Northwind.MVCWebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());

            System.Web.Mvc.ModelBinders.Binders.Add(typeof(Cart),new CartModelBinder());
        }
    }
}

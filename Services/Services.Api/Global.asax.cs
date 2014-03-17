using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Services.App_Start;
using log4net;

namespace Services
{
	public class WebApiApplication : System.Web.HttpApplication
	{
		private readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			GlobalConfiguration.Configure(WebApiConfig.Register);

			RouteConfig.RegisterRoutes(RouteTable.Routes);
		}

		protected void Application_Error(object sender, EventArgs e)
		{
			Exception exception = Server.GetLastError().GetBaseException();
			log.Error("Unhandled Application Exception", exception);
		}
	}
}

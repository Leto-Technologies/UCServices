using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Services.Areas.HelpPage.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /HelpPage/Home/
        public ActionResult Index()
        {
			return Redirect(Request.Url.AbsoluteUri + "/help");
        }
	}
}
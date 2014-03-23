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
			// don't know why, but by default you were getting redirected to //help sometimes.
	        var url = (Request.Url.AbsolutePath + "/help").Replace("//", "/");

			return Redirect(url);
        }
	}
}
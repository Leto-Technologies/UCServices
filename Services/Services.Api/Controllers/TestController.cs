using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;
using log4net;

namespace Services.Controllers
{
    /// <summary>
    /// Testing infrastructure setup
    /// </summary>
    public class TestController : ApiController
    {
		private readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		/// <summary>
		/// A hello world method
		/// </summary>
		/// <returns></returns>
		public IHttpActionResult Get()
		{
			log.Info("Logging works!");

			return Ok("Hello world");
		}
    }
}

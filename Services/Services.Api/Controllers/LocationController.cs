using System.Web.Http;
using Services.DAL;

namespace Services.Controllers
{
	/// <summary>
	/// Given a latitude, longitude, and radius- returns the closest locations ordered by distance.
	/// </summary>
	/// <returns>
	/// A list of <see cref="Address">Addresses</see>
	/// </returns>
    public class LocationController : ApiController
    {
		public IHttpActionResult Get(double latitude, double longitude, int radius)
		{
			var repo = new LocationRepository();

			return Ok(repo.GetLocations(latitude, longitude, radius));
		}
    }
}

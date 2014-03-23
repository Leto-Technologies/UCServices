using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Npgsql;
using Services.Model;

namespace Services.DAL
{
	public class LocationRepository
	{
		public List<Location> GetLocations(double latitude, double longitude, int radius)
		{
			var ds = new DataSet();
			var dt = new DataTable();

			var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["CareWait"].ConnectionString);

			connection.Open();


			var query = string.Format("SELECT * FROM GetAddresses({0}, {1}, {2});", latitude, longitude, radius);

			var command = new Npgsql.NpgsqlCommand(query, connection);


			NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
			da.Fill(ds);
			
			dt = ds.Tables[0];
			
			// since we only showing the result we don't need connection anymore
			connection.Close();


			var locations = new List<Location>();

			// todo: replace this with some sort of reflection
			foreach (DataRow row in dt.Rows)
			{
				var distance = row.Field<double>("distance");
				var name = row.Field<string>("name");
				var street = row.Field<string>("street");
				var street2 = row.Field<string>("street2");
				var city = row.Field<string>("city");
				var state = row.Field<string>("state");
				var zip = row.Field<string>("zip");
				var lat = row.Field<double>("latitude");
				var lon = row.Field<double>("longitude");

				locations.Add(new Location(name, street, street2, city, state, zip, lat, lon, distance));
			}

			return locations;
		}
	}
}

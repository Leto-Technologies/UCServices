namespace Services.Model
{
	public class Location
	{
		public Location()
		{
			
		}

		public Location(int id, string name, string address1, string address2, string city, string state, string zip, double latitude, double longitude, double distance)
		{
			Id = id;
			Name = name;
			Address1 = address1;
			Address2 = address2;
			City = city;
			State = state;
			Zip = zip;
			Latitude = latitude;
			Longitude = longitude;
			Distance = distance;
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string Zip { get; set; }
		public string State { get; set; }
		public string City { get; set; }

		public double Latitude { get; set; }
		public double Longitude { get; set; }

		public double Distance { get; set; }
	}
}
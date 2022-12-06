namespace WinFormsApp_Example
{
	public class Car
	{
		public int Id { get;  set; }
		public string Model { get; set; }
		public string Brand { get; set; }
		public string CountryOfBilding { get; set; }
		public string Nayavnost { get;  set; }
		public string EngineVolume { get; set; }
		public double FuelConsumption { get; set; }
	}

    public class NotAvaileble : Car
    {
        public NotAvaileble(int id, string brand, string model, double fuelcons, string countryofbuild)
        {
            Id = id;
            Brand = brand;
            Model = model;
            CountryOfBilding = countryofbuild;
			EngineVolume = $"Обєм мотора: {fuelcons.ToString()} л.";
			Nayavnost = @"Нема в наявності";
        }
    }

    public class InAvaible : Car
	{
		public InAvaible(int id, string brand, string model, double fuelcons, string countryofbuild)
		{
			Id = id;
			Brand= brand;
			Model = model;
			CountryOfBilding = countryofbuild;
			EngineVolume = $"Обєм мотора: {fuelcons.ToString()} л.";
			Nayavnost = @"В наявності";
		}

	}

	public enum CarType
	{
		InAvaible,
		NotAvaible
	}
}
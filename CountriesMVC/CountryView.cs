using System;
namespace CountriesMVC
{
	public class CountryView
	{
        public Country DisplayCountry { get; set; }
        public CountryView(Country country)
		{
			DisplayCountry = country;
		}

		public void Display()
        {
			string colors = "";
			DisplayCountry.Colors.ForEach(x => colors += x + ", ");

            Console.WriteLine("Country Name: " + DisplayCountry.Name);
			Console.WriteLine("Continent: " + DisplayCountry.Continent);
			Console.WriteLine("Colors: " + colors);
		}
	}
}


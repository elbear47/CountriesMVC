using System;
namespace CountriesMVC
{
	public class Country
	{
        public string Name { get; set; }
        public Continent Continent { get; set; }
		public List<string> Colors { get; set; }


        public Country(string name, Continent continent, List<string> colors)
		{
			Name = name;
			Continent = continent;
			Colors = colors;
		}
	}
}


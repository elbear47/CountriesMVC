using System;
namespace CountriesMVC
{
	public class CountryController
	{
        public List<Country> CountryDb { get; set; } = new List<Country>()
		{
			new Country(
				"United States of America",
				Continent.North_America,
				new List<string>(){"Red","White","Blue"}),
			new Country(
				"Egypt",
				Continent.Africa,
				new List<string>(){"Red","White","Black"}),
			new Country(
				"Venezuela",
				Continent.South_America,
				new List<string>(){"Yellow","Blue","Red"}),
			new Country(
				"China",
				Continent.Asia,
				new List<string>(){"Red","Yellow"}),
			new Country(
				"Turkey",
				Continent.Asia,
				new List<string>(){"Red","White"}),
			new Country(
				"Spain",
				Continent.Europe,
				new List<string>(){"Red","Yellow","White"}),
		};

        public CountryController()
		{
		}

		public void CountryAction(Country c)
        {
			CountryView cv = new CountryView(c);

			cv.Display(); // display country


        }

		public void WelcomeAction()
        {
			bool willContinue = true;
            do
            {

                CountryListView clv = new CountryListView(CountryDb);
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:”");

                clv.Display();

                CountryAction(CountryDb[getCountrySelection() - 1]);

                Console.WriteLine("\nWould you like to select another country?(y/n)");
				string ansys = Console.ReadLine().ToLower();
				if (ansys == "y")
				{
					willContinue = true;
				}
                else
                {
                    Console.WriteLine("Goodbye!");
					willContinue = false;
				}
					


            } while (willContinue);
			
		}

		public int getCountrySelection()
        {
            int countrySelected = int.Parse(Console.ReadLine());
			return countrySelected;
        }
	}
}


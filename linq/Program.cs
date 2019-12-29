using System;
using System.Collections;
using System.Linq;

namespace linq
{
    class Country
    {
        public string Name { get; set; }
        public int Population { get; set; }

        public Country(string name, int population)
        {
            Name = name;
            Population = population;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Country[] countryCollection ={
                new Country("Afghanistan",34656032),
                new Country("Austria",8857960),
                new Country("Brazil", 210147125),
                new Country("Denmark",5789957),
                new Country("Russia",144526636),
                new Country("China",1403500365),
                new Country("Turkey",80810525),
                new Country("Serbia",7001444),
                new Country("Iraq",37202572),
                new Country("San Marino",33344)};

            var popInfo = from info in countryCollection
                          orderby info.Population descending, info.Name
                          select info;

            foreach(Country info in popInfo)
            {
                Console.WriteLine("Country: {0} {1}", info.Name, info.Population);
                //neka izmjena
            }

                         


        }
    }
}

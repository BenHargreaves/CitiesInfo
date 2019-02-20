using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CitiesDto> Cities { get; set; }
        public CitiesDataStore()
        {
            //init dummy data
            Cities = new List<CitiesDto>()
            {
                new CitiesDto()
                {
                    Id = 1,
                    Name = "Toronto",
                    Description = "Cold and then Construction."
                },
                new CitiesDto()
                {
                    Id = 2,
                    Name = "New York City",
                    Description = "Home of the Teenage Mutant Ninja Turtles"
                },
                new CitiesDto()
                {
                    Id = 3,
                    Name = "Brisbane",
                    Description = "Sunny times always."
                }
            };
        }
    }
}

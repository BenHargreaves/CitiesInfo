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
                    Description = "Cold and then Construction.",
                    PointsOfInterest = new List<PointsOfInterestDTO>()
                    {
                        new PointsOfInterestDTO()
                        {
                            Id = 1,
                            Name = "CN Tower",
                            Description = "Pointy"
                        },
                        new PointsOfInterestDTO()
                        {
                            Id = 2,
                            Name = "Drake Hotel",
                            Description = "Issa OVO Ting"
                        }
                    }
                },
                new CitiesDto()
                {
                    Id = 2,
                    Name = "New York City",
                    Description = "Home of the Teenage Mutant Ninja Turtles",
                    PointsOfInterest = new List<PointsOfInterestDTO>()
                    {
                        new PointsOfInterestDTO()
                        {
                            Id = 3,
                            Name = "Central Park",
                            Description = "The Hardest part to get around in the Spider Man game"
                        },
                        new PointsOfInterestDTO()
                        {
                            Id = 4,
                            Name = "Avengers Tower",
                            Description = "Assemble!"
                        }
                    }
                },
                new CitiesDto()
                {
                    Id = 3,
                    Name = "Brisbane",
                    Description = "Sunny times always.",
                    PointsOfInterest = new List<PointsOfInterestDTO>()
                    {
                        new PointsOfInterestDTO()
                        {
                            Id = 5,
                            Name = "South Bank",
                            Description = "Man made beach 20min away from a real one for some reason"
                        },
                        new PointsOfInterestDTO()
                        {
                            Id = 6,
                            Name = "QUT Gardens Point",
                            Description = "Where all the geniuses go."
                        }
                    }
                }
            };
        }
    }
}

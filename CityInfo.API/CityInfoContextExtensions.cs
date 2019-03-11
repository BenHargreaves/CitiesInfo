using CityInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public static class CityInfoContextExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            var cities = new List<City>()
            {
                new City()
                {
                    Name = "Toronto",
                    Description = "Cold and then Construction.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "CN Tower",
                            Description = "Pointy"
                        },
                        new PointOfInterest()
                        {
                            Name = "Drake Hotel",
                            Description = "Issa OVO Ting"
                        }
                    }
                },
                new City()
                {
                    Name = "New York City",
                    Description = "Home of the Teenage Mutant Ninja Turtles",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Central Park",
                            Description = "The Hardest part to get around in the Spider Man game"
                        },
                        new PointOfInterest()
                        {
                            Name = "Avengers Tower",
                            Description = "Assemble!"
                        }
                    }
                },
                new City()
                {
                    Name = "Brisbane",
                    Description = "Sunny times always.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "South Bank",
                            Description = "Man made beach 20min away from a real one for some reason"
                        },
                        new PointOfInterest()
                        {
                            Name = "QUT Gardens Point",
                            Description = "Where all the geniuses go."
                        }
                    }
                }
            };

            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}

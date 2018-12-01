using ReactTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReactTemplate.Controllers;

namespace ReactTemplate
{
    public class CitiesDataStore
    {
        public List<CityDto> ListOfCieties { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public CitiesDataStore()
        {

            ListOfCieties = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name="New York",
                    Description = "asdf",

                    PointsOfInterest = new List<PointOfInterstsDto>()
                     {
                         new PointOfInterstsDto() {
                             Id = 1,
                             Name = "Central Park",
                             Description = "The most visited urban park in the United States." },
                          new PointOfInterstsDto() {
                             Id = 2,
                             Name = "Empire State Building",
                             Description = "A 102-story skyscraper located in Midtown Manhattan." },
                     }

                },
                new CityDto()
                {
                    Id = 2,
                    Name="New 2 York",
                    Description = "asdf",

                    PointsOfInterest = new List<PointOfInterstsDto>()
                     {
                         new PointOfInterstsDto() {
                             Id = 3,
                             Name = "Cathedral of Our Lady",
                             Description = "A Gothic style cathedral, conceived by architects Jan and Pieter Appelmans." },
                          new PointOfInterstsDto() {
                             Id = 4,
                             Name = "Antwerp Central Station",
                             Description = "The the finest example of railway architecture in Belgium." },
                     }
                },
                new CityDto()
                {
                    Id = 3,
                    Name="New 3 York",
                    Description = "asdf",

                    PointsOfInterest = new List<PointOfInterstsDto>()
                     {
                         new PointOfInterstsDto() {
                             Id = 3,
                             Name = "Cathedral of Our Lady",
                             Description = "A Gothic style cathedral, conceived by architects Jan and Pieter Appelmans." },
                          new PointOfInterstsDto() {
                             Id = 4,
                             Name = "Antwerp Central Station",
                             Description = "The the finest example of railway architecture in Belgium." },
                     }
                },
            };

        }
    }
}
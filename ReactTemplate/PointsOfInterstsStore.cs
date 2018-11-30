using ReactTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactTemplate
{
    public class PointsOfInterstsStore
    { 
    public List<PointOfInterstsDto> ListOfPointOfInterstsDto { get; set; }
    public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public PointsOfInterstsStore()
        {

            ListOfPointOfInterstsDto = new List<PointOfInterstsDto>()
            {
                new PointOfInterstsDto()
                {
                    Id = 1,
                    Name="New York",
                    Description = "asdf"
                },
                new PointOfInterstsDto()
                {
                    Id = 2,
                    Name="New 2 York",
                    Description = "asdf"
                },
                new PointOfInterstsDto()
                {
                    Id = 3,
                    Name="New 3 York",
                    Description = "asdf"
                },
            };
        }
    }

}

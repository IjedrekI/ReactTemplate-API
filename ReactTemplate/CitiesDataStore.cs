using ReactTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                    Description = "asdf"
                },
                new CityDto()
                {
                    Id = 2,
                    Name="New 2 York",
                    Description = "asdf"
                },
                new CityDto()
                {
                    Id = 3,
                    Name="New 3 York",
                    Description = "asdf"
                },
            };

        }
    }
}

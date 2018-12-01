using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactTemplate.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<PointOfInterstsDto> PointsOfInterest { get; set; } = new List<PointOfInterstsDto>(); 

        public int NumberOfPointsOFInterest
        {
            get { return PointsOfInterest.Count; }
        }
       

    }
    
}

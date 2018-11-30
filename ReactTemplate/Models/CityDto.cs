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
        public int NumberOfPointsOFInterest
        {
            get { return PointsOInterest.Count; }
        }
        public ICollection<PointOfInterstsDto> PointsOInterest { get; set; } = new List<PointOfInterstsDto>();

    }
    
}

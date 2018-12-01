using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ReactTemplate.Controllers
{
    [Route("api/cieties")]
    public class PointsOfInterstsController : Controller
    {
        [HttpGet("{cityId}/pointsorinterest")]
        public IActionResult GetPointsOfInterest(int cityid)
        {
            var city = CitiesDataStore.Current.ListOfCieties.FirstOrDefault(c => c.Id == cityid);
            if (city.Equals(null)) { return NotFound(); }
           // if(city.PointsOfInterest.Equals(null)) { return NotFound();  }

            return Ok(city.PointsOfInterest);
        }
     [HttpGet("{cityId}/{pointofinterestId}")]
     public IActionResult GetPointOfInterest(int cityid, int pointOfInterestId)
     {
         var city = CitiesDataStore.Current.ListOfCieties.FirstOrDefault(c => c.Id == cityid);
         if (city.Equals(null)) { return NotFound(); }

         var pointOfInterest = city.PointsOfInterest.FirstOrDefault(s => s.Id == pointOfInterestId);
         if (city.PointsOfInterest.Equals(null)) { return NotFound(); }

          return Ok(pointOfInterest);
     }



    }
}
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
        [HttpGet("{cityId}/pointorinterest")]
        public IActionResult GetPointOfInterest(int cityid)
        {
            var city = CitiesDataStore.Current.ListOfCieties.FirstOrDefault(c => c.Id == cityid);
            if (city.Equals(null)) { return NotFound(); }


            return Ok(city.PointsOInterest);
        }
    }
}
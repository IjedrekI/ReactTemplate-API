using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ReactTemplate.Controllers
{
    public class CietiesController : Controller
    {
        [HttpGet("api/cieties")]
        public IActionResult GetCieties()
        {
            return Ok(CitiesDataStore.Current.ListOfCieties);
        }

        [HttpGet("api/cieties/{id}")]
        public IActionResult GetCity(int id)
        {
            var cityToReturn = new JsonResult(CitiesDataStore.Current.ListOfCieties.FirstOrDefault(c => c.Id == id));
            if (cityToReturn.Value == null)
            {
                return NotFound();
            }

            return Ok(cityToReturn);
        }
    }
}
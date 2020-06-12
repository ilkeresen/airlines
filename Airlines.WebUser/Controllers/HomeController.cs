using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Airlines.WebUser.Models;
using Airlines.Data.Abstract;

namespace Airlines.WebUser.Controllers
{
    public class HomeController : Controller
    {
        IAirlineRepository airlineRepository;

        public HomeController(IAirlineRepository _airlineRepository)
        {
            airlineRepository = _airlineRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetList(string Departure, string Arrival, DateTime Date)
        {
            var airlineControl = airlineRepository.GetByName(Departure, Arrival, Date);
            if (airlineControl != null)
            {
                return View(airlineControl);
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

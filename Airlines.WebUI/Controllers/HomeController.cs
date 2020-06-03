using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Airlines.WebUI.Models;
using Airlines.Data.Abstract;
using Airlines.Entity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace Airlines.WebUI.Controllers
{

    [Authorize]
    public class HomeController : Controller
    {
        private IAirlineRepository airlineRepository;

        public HomeController(IAirlineRepository repository)
        {
            airlineRepository = repository;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AirlineList()
        {
            return View(airlineRepository.GetAll());
        }

        [HttpGet]
        public IActionResult AirlineCreate()
        {
            //ViewBag.Airlines = new SelectList(airlineRepository.GetAll(), "AirlineId", "AirlineNumber").Count()+1;

            return View();
        }

        [HttpPost]
        public IActionResult AirlineCreate(Flight entity)
        {
            if (ModelState.IsValid)
            {
                airlineRepository.AddAirline(entity);
                return RedirectToAction("AirlineList");
            }

            return View(entity);
        }

        [HttpGet]
        public IActionResult AirlineEdit(int id)
        {
            return View(airlineRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult AirlineEdit(Flight entity)
        {
            if (ModelState.IsValid)
            {
                airlineRepository.UpdateAirline(entity);
                TempData["message"] = $"Id : {entity.FlightId} Kalkış : {entity.Departure} Varış : {entity.Arrival} Uçuş Güncellendi";
                return RedirectToAction("AirlineList");
            }

            return View(entity);
        }

        [HttpGet]
        public IActionResult AirlineDelete(int id)
        {
            return View(airlineRepository.GetById(id));
        }

        [HttpPost, ActionName("AirlineDelete")]
        public IActionResult AirlineDeleteConfirmed(int AirlineId)
        {
            airlineRepository.DeleteAirline(AirlineId);
            TempData["message"] = $"{AirlineId} Numaralı Uçuş Silindi.";
            return RedirectToAction("AirlineList");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

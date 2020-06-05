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
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace Airlines.WebUI.Controllers
{

    [Authorize]
    public class HomeController : Controller
    {
        private IAirlineRepository airlineRepository;
        private IPlaneRepository planeRepository;

        public HomeController(IAirlineRepository repository, IPlaneRepository _planeRepository)
        {
            airlineRepository = repository;
            planeRepository = _planeRepository;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            if (HttpContext.User.Claims.Any())
            {
                return RedirectToAction("AirlineList");
            }
            return View();
        }

        public IActionResult AirlineList()
        {
            return View(airlineRepository.GetAll());
        }

        [HttpGet]
        public IActionResult AirlineCreate()
        {
            ViewBag.PlanesName = new SelectList(planeRepository.GetAll(), "PlaneId", "PlaneName");

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Airlines.Data.Concrete.EfCore;
using Airlines.Entity;
using Airlines.Data.Abstract;
using Airlines.WebUI.Models;
using System.Diagnostics;

namespace Airlines.WebUI.Controllers
{
    public class PlanesController : Controller
    {
        private IPlaneRepository planeRepository;

        public PlanesController(IPlaneRepository _planeRepository)
        {
            planeRepository = _planeRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PlaneList()
        {
            return View(planeRepository.GetAll());
        }

        [HttpGet]
        public IActionResult PlaneCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PlaneCreate(Plane entity)
        {
            if (ModelState.IsValid)
            {
                planeRepository.AddPlane(entity);
                return RedirectToAction("PlaneList");
            }

            return View(entity);
        }

        [HttpGet]
        public IActionResult PlaneEdit(int id)
        {
            return View(planeRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult PlaneEdit(Plane entity)
        {
            if (ModelState.IsValid)
            {
                planeRepository.UpdatePlane(entity);
                TempData["message"] = $"Id : {entity.PlaneId} İsimli : {entity.PlaneName} Tipli : {entity.PlaneType} Uçak Bilgileri Güncellendi";
                return RedirectToAction("PlaneList");
            }

            return View(entity);
        }

        [HttpGet]
        public IActionResult PlaneDelete(int id)
        {
            return View(planeRepository.GetById(id));
        }

        [HttpPost, ActionName("PlaneDelete")]
        public IActionResult PlaneDeleteConfirmed(int PlaneId)
        {
            planeRepository.DeletePlane(PlaneId);
            TempData["message"] = $"{PlaneId} Numaralı Kullanıcı Silindi.";
            return RedirectToAction("PlaneList");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

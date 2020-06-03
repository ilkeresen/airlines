﻿using System;
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
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace Airlines.WebUI.Controllers
{
    
    public class UsersController : Controller
    {
        private IUserRepository userRepository;

        public UsersController(IUserRepository repository)
        {
            userRepository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserLogin(string UserEmail, string UserPassword)
        {
            if (!string.IsNullOrEmpty(UserEmail) && string.IsNullOrEmpty(UserPassword))
            {
                return RedirectToAction("Index", "Home");
            }

            //Check the user name and password
            //Here can be implemented checking logic from the database
            ClaimsIdentity identity = null;
            bool isAuthenticated = false;

            if (UserEmail == "ilkeresen@hotmail.com" && UserPassword == "password")
            {

                //Create the identity for the user
                identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, UserEmail),
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                isAuthenticated = true;
            }

            if (isAuthenticated)
            {
                var principal = new ClaimsPrincipal(identity);

                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("AirlineList", "Home");
            }
            return View();
        }

        [HttpPost]
        public IActionResult UserLogout()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Users");
        }

        public IActionResult UserList()
        {
            //ViewData["UserName"] = new SelectList(userRepository.GetAll(), "UserId", "UserName");
            return View(userRepository.GetAll());
        }

        [HttpGet]
        public IActionResult UserCreate()
        {
            //ViewBag.Airlines = new SelectList(airlineRepository.GetAll(), "AirlineId", "AirlineNumber").Count()+1;

            return View();
        }

        [HttpPost]
        public IActionResult UserCreate(User entity)
        {
            if (ModelState.IsValid)
            {
                userRepository.AddUser(entity);
                return RedirectToAction("UserList");
            }

            return View(entity);
        }

        [HttpGet]
        public IActionResult UserEdit(int id)
        {
            return View(userRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult UserEdit(User entity)
        {
            if (ModelState.IsValid)
            {
                userRepository.UpdateUser(entity);
                TempData["message"] = $"Id : {entity.UserId} İsimli : {entity.UserName} E-Postalı : {entity.UserEmail} Kullanıcı Bilgileri Güncellendi";
                return RedirectToAction("UserList");
            }

            return View(entity);
        }

        [HttpGet]
        public IActionResult UserDelete(int id)
        {
            return View(userRepository.GetById(id));
        }

        [HttpPost, ActionName("UserDelete")]
        public IActionResult UserDeleteConfirmed(int UserId)
        {
            userRepository.DeleteUser(UserId);
            TempData["message"] = $"{UserId} Numaralı Kullanıcı Silindi.";
            return RedirectToAction("UserList");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

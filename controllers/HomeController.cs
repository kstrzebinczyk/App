using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using App.Models;
using System.Data.SQLite;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserModel user)
        {
            using (var db = new App.Models.AppDbContext())
            {
                if(ModelState.IsValid)
                {
                    db.Add(user);
                    db.SaveChanges();
                }
            }
            return View();
        }
        public IActionResult LogIn()
        {
            using (var db = new App.Models.AppDbContext())
            {
                
            }
            return View();
        }
    }
}

/* 
TODO - Add logic for login 
TODO - Add data encryption
*/
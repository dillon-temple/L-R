using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LandR.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace LandR.Controllers
{
    public class HomeController : Controller
    {

        private MyContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Success")]
        public IActionResult Success()
        {
            if(HttpContext.Session.GetInt32("Logged") == 1){
                return View();
            }
            return View("Index");
        }
        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }


        
        [HttpPost("Register")]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                dbContext.Add(user);
                dbContext.SaveChanges();
                return View("Login");

            }
            return View("Index");
        }
        [HttpGet("LoginPage")]
        public IActionResult LoginPage()
        {
            return View("Login");
        }

        public IActionResult LoginAction(User user)
        {
            var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == user.Email);

            if (userInDb == null)
            {
                ModelState.AddModelError("Email", "Invalid Email/Password");
                return View("Login");
            }

            var hasher = new PasswordHasher<User>();
            var result = hasher.VerifyHashedPassword(user, userInDb.Password, user.Password);

            if (result == 0)
            {
                ModelState.AddModelError("Email", "Invalid Email/Password");
                return View("Login");
            }

            HttpContext.Session.SetInt32("Logged", 1);
            return RedirectToAction("Success");
        }
    }
}

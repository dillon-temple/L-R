using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAccount.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;


namespace BankAccount.Controllers
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
        [HttpGet("Bank/{id}")]
        public IActionResult Bank(int id)
        {
            if(HttpContext.Session.GetInt32("Logged") == id){

                User current = dbContext.Users.FirstOrDefault(user => user.UserId == id);
                List<Transaction> transactions = dbContext.Transactions.Where(u => u.UserId == id).ToList();
                ViewBag.user = current;

                float balance = 0;
                foreach (var amount in transactions)
                {
                    balance += amount.Amount;
                }

                ViewBag.balance = balance;
                return View("Bank", transactions);
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
        [HttpPost("LoginAction")]
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

            HttpContext.Session.SetInt32("Logged", userInDb.UserId);
            Console.WriteLine(userInDb.UserId);
            int id = userInDb.UserId;
            return RedirectToAction("Bank", new {id = id});
        }

        [HttpPost("Bank/Calculate")]
        public IActionResult Calculate(float Amount){

            int id = (int)HttpContext.Session.GetInt32("Logged");

            List<Transaction> CustomerRecord = dbContext.Transactions
            .Where(u => u.UserId == id)
            .OrderByDescending(u => u.CreatedAt)
            .ToList();

            float balance = 0;

            foreach(var amount in CustomerRecord){
                balance += amount.Amount;
            }

            if(balance + Amount < 0){
                ModelState.AddModelError("Amount", "You dont have enough money!");

            } 
            else
            {
                Transaction trans = new Transaction();

                trans.UserId = id;
                trans.Amount = Amount;
                dbContext.Add(trans);
                dbContext.SaveChanges();
                
            }
            return RedirectToAction("Bank", new {id = id});
        }
    }
}

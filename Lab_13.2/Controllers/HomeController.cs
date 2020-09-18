using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dapper;
using Lab_13._2.Models;
using System.Data;
using System.Data.SqlClient;

namespace Lab_13._2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            //Product prod = Product.Create("Kitty Litter", 13.95m, "Food", "Cat Food");
            //return Content($"{prod.ProductID} {prod.ProductName} {prod.Price} {prod.Description} {prod.Category}");

            return View();
        }

        [HttpGet]
        public IActionResult OrderMenu()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderConfirmation(string drink, string size, string selection, string time, string firstname, string lastname, string streetAddress1, string streetAddress2, string city, string state, string zipCode, string country)
        {

            WebOrder webOrder1 = new WebOrder()
            {
                Drink = drink,
                Size = size,
                Selection = selection,
                Time = time,
                FirstName = firstname,
                LastName = lastname,
                StreetAddress1 = streetAddress1,
                StreetAddress2 = streetAddress2,
                City = city,
                State = state,
                ZipCode = zipCode,
                Country = country
            };

            ViewBag.ThankYou = "Thank you for your order. Below is your order";
            return View(webOrder1);
        }

        //public IActionResult Testing()
        //{
        //    CoffeeTable prod = CoffeeTable.Create("Kitty Litter", 13.95m);
        //    return Content($"{prod.ProductID} {prod.ProductName} {prod.Price}");
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

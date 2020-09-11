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

            ViewBag.ThankYou = "Thank you for your order. Below is your order";
            return View();
        }

        public IActionResult Testing()
        {
            IDbConnection db = new SqlConnection("Server=GWJSN13\\SQLEXPRESS; Database=Coffee2; Trusted_Connection=Yes");
            db.Open();
            List<CoffeeTable> order = db.Query<CoffeeTable>("SELECT * FROM CoffeeTable").AsList<CoffeeTable>();
            db.Close();
     
            return View(order);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

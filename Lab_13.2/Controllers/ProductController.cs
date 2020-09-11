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
    public class ProductController : Controller
    {
        public IActionResult Product()
        {
            IDbConnection db = new SqlConnection("Server=GWJSN13\\SQLEXPRESS; Database=Coffee2; Trusted_Connection=Yes");
            db.Open();
            List<CoffeeTable> order = db.Query<CoffeeTable>("SELECT * FROM CoffeeTable").AsList<CoffeeTable>();

            //foreach (CoffeeTable Field in order)
            //{
            //    Console.WriteLine($"{Field.ProductID} {Field.ProductName} {Field.Description}");
            //}

            db.Close();

            return View(order);
            
        }

        public IActionResult Detail(int ProductID)
        {
            IDbConnection db = new SqlConnection("Server=GWJSN13\\SQLEXPRESS; Database=Coffee2; Trusted_Connection=Yes");
            db.Open();
            CoffeeTable details = db.QuerySingle<CoffeeTable>($"SELECT * FROM CoffeeTable WHERE ProductID = {ProductID}");
            db.Close();
            return View(details);
        }
    }
}

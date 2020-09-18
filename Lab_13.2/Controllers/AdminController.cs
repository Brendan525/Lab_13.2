using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using Lab_13._2.Models;

namespace Lab_13._2.Controllers
{
    public class AdminController : Controller
    {
        
        public IActionResult Index()
        {
            IDbConnection db = new SqlConnection("Server=GWJSN13\\SQLEXPRESS; Database=Coffee2; user id=admin; password=pass1;");
            db.Open();
            List<CoffeeTable> prod = db.Query<CoffeeTable>("SELECT * FROM CoffeeTable").AsList<CoffeeTable>();
            db.Close();
          

            return View(prod);
        }

        public IActionResult Add()
        {
            ViewBag.PageName = "Add";
            return View();
        }

        public IActionResult SaveNew(long productID, string productName, string productDescription, decimal productPrice, string productCategory)
        {

            if (productID >= 1)
            {
                CoffeeTable.Update(productID, productName, productDescription, productPrice, productCategory);
            }     
            else
            {
                CoffeeTable.Create(productName, productDescription, productPrice, productCategory);
            }
       
            ViewBag.Message = "The Product has been saved.";
            List<CoffeeTable> prod = CoffeeTable.Read();
            return View("Index", prod); 
        }

        public IActionResult Edit(long ProductID)
        {
            ViewBag.PageName = "Edit";
            CoffeeTable prod = CoffeeTable.Read(ProductID);
            ViewBag.ProductID = prod.ProductID;
            ViewBag.ProductName = prod.ProductName;
            ViewBag.ProductDescription = prod.Description;
            ViewBag.ProductPrice = prod.Price;
            ViewBag.ProductCategory = prod.Category;
            return View("Add");
        }

        public IActionResult Delete(long ProductID)
        {
            //IDbConnection db = new SqlConnection("Server=GWJSN13\\SQLEXPRESS; Database=Coffee2; user id=admin; password=pass1;");
            //db.Open();
            //CoffeeTable.Delete(ProductID);
            //db.Close();
            //return View("Add");

            CoffeeTable.Read(ProductID);
            CoffeeTable.Delete(ProductID);
            return View("Delete");
        }


        public IActionResult Test2()
        {
            IDbConnection db = new SqlConnection("Server=GWJSN13\\SQLEXPRESS; Database=Coffee2; user id=admin; password=pass1;");
            db.Open();
            CoffeeTable.Delete(4);
            db.Close();
            return View("Delete");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using System.Data;

namespace Lab_13._2.Models
{
    [Table("CoffeeTable")]
    public class Product
    {

        [Key]
        public long ProductID { get; set; }


        public string ProductName { get; set; }

        public Decimal Price { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }



        public static Product Create(string _name, Decimal _price, string _category, string _description) // Creates a product
        {
            // Create the new Product instance
            Product prod = new Product() { ProductName = _name, Price = _price, Category = _category, Description = _description};

            // Save it to the database     
            IDbConnection db = new SqlConnection("Server=GWJSN13\\SQLEXPRESS; Database=Coffee2; user id=admin; password=abc123;");
            long _id = db.Insert<Product>(prod);

            // Set the id column of the instance
            prod.ProductID = _id;

            // Return the instance
            return prod;
        }

        //public static Product Read(long _id)
        //{
        //    IDbConnection db = new SqlConnection("Server=GWJSN13\\SQLEXPRESS; Database=Coffee2; user id=admin; password=abc123;");
        //    Product prod = db.Get<Product>(_id);
        //    return prod;
        //}

        //public static List<Product> Read()
        //{
        //    IDbConnection db = new SqlConnection("Server=GWJSN13\\SQLEXPRESS; Database=Coffee2; user id=admin; password=abc123;");
        //    List<Product> prod = db.GetAll<Product>().ToList();
        //    return prod;
        //}

        //public void Save()
        //{
        //    IDbConnection db = new SqlConnection("Server=GWJSN13\\SQLEXPRESS; Database=devbuildjoin; Trusted_Connection=Yes");
        //    db.Update(this);
        //}

        //public static void Delete(long _id)
        //{
        //    IDbConnection db = new SqlConnection("Server=GWJSN13\\SQLEXPRESS; Database=Coffee2; user id=admin; password=abc123;");
        //    db.Delete(new Product() { ProductID = _id });
        //}

    }
}

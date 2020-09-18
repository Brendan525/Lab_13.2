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
    public class CoffeeTable
    {
        [Key]
        public long ProductID { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }


        public static List<CoffeeTable> Read()
        {
            IDbConnection db = new SqlConnection("Server=GWJSN13\\SQLEXPRESS; Database=Coffee2; user id=admin; password=pass1;");
            List<CoffeeTable> prod = db.GetAll<CoffeeTable>().ToList();
            return prod;
        }

        public static CoffeeTable Read(long _id)
        {
            IDbConnection db = new SqlConnection("Server=GWJSN13\\SQLEXPRESS; Database=Coffee2; user id=admin; password=pass1;");
            CoffeeTable prod = db.Get<CoffeeTable>(_id);
            return prod;
        }

        public static void Create(string _productName, string _description, decimal _price, string _category) // Creates a product
        {
            // Create the new Product instance
            CoffeeTable prod = new CoffeeTable() { ProductName = _productName, Description = _description, Price = _price, Category = _category };

            // Save it to the database     
            IDbConnection db = new SqlConnection("Server=GWJSN13\\SQLEXPRESS; Database=Coffee2; user id=admin; password=pass1;");
            long _id = db.Insert<CoffeeTable>(prod);

            // Set the id column of the instance
            //prod.ProductID = _id;

            // Return the instance
            //return prod;
        }

        public static void Update(long _productID, string _productName, string _description, decimal _price, string _category)
        {         
            CoffeeTable prod = new CoffeeTable() { ProductID = _productID, ProductName = _productName, Description = _description, Price = _price, Category = _category }; 
            IDbConnection db = new SqlConnection("Server=GWJSN13\\SQLEXPRESS; Database=Coffee2; user id=admin; password=pass1;");
            db.Update(prod);
        }

        public static void Delete(long _id)
        {
            IDbConnection db = new SqlConnection("Server=GWJSN13\\SQLEXPRESS; Database=Coffee2; user id=admin; password=pass1;");
            db.Delete(new CoffeeTable() { ProductID = _id });
        }
    }
}

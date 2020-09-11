using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace Lab_13._2.Models
{
    public class WebOrder
    {
        public string Drink { get; set; }

        public string Size { get; set; }

        public string Selection { get; set; }

        public string Time { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StreetAddress1 { get; set; }

        public string StreetAddress2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }

        public bool Empty
        {
            get
            {
                return (string.IsNullOrEmpty(FirstName));
            }
        }
    }
}
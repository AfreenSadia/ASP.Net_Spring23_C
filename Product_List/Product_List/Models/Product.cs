using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Product_List.Models
{
    public class Product
    {
        private int id;
        private string name;
        private double price;

        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public double Price
        {
            get { return price; }
            set { this.price = value; }
        }


        public Product(int id, string name, double price) // Parametrized Constructor
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        public Product()
        {
        }
    }
    

}
using System;
using System.Collections.Generic;
using System.Text;

namespace P03_SalesDatabase.Data.Models
{
    public class Product
    {
        public Product()
        {

        }

        public Product(string name, double qty, decimal price, string description)
        {
            this.Name = name;
            this.Quantity = qty;
            this.Price = price;
            this.Description = description;
        }

        public int ProductId { get; set; }

        public string Name { get; set; }

        public double Quantity { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }


        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }
}

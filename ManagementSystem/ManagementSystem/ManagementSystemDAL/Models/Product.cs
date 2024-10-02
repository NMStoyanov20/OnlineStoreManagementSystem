using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemDAL.Models
{
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        protected Product(string name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public abstract void DisplayProductDetails();

        public bool IsInStock(int quantity)
        {
            return Stock >= quantity;
        }

        public void DeductStock(int quantity)
        {
            Stock -= quantity;
        }
    }
}

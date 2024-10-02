using ManagementSystemDAL.Interfaces;
using ManagementSystemDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemBLL.Models
{
    public class Order
    {
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public IDiscount Discount { get; set; }
        public IPayment PaymentMethod { get; set; }

        public Order(Customer customer, Product product, int quantity, IDiscount discount, IPayment paymentMethod)
        {
            Customer = customer;
            Product = product;
            Quantity = quantity;
            Discount = discount;
            PaymentMethod = paymentMethod;
        }

        public void ProcessOrder()
        {
            if (!Product.IsInStock(Quantity))
            {
                Console.WriteLine("Insufficient stock for the product.");
                return;
            }

            decimal total = Product.Price * Quantity;
            total = Discount.ApplyDiscount(total);
            Product.DeductStock(Quantity);

            PaymentMethod.ProcessPayment(total);

            Console.WriteLine("Order processed successfully!");
        }
    }
}

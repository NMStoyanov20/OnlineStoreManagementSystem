using ManagementSystemBLL.Models;
using ManagementSystemDAL.Interfaces;
using ManagementSystemDAL.Models;
using ManagementSystemPL.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemPL
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerController customerController = new CustomerController();
            Customer customer = new Customer("Nikola", "Stoyanov");
            customerController.DisplayCustomerInfo(customer);

            ProductController productController = new ProductController();
            Product physicalProduct = new PhysicalProduct("Laptop", 1200m, 10);
            Product digitalProduct = new DigitalProduct("Computer-Mouse", 15m, 100);

            productController.DisplayProductDetails(physicalProduct);
            productController.DisplayProductDetails(digitalProduct);

            IDiscount discount = new PercentageDiscount(10); 
            IPayment paymentMethod = new CreditCardPayment();

            OrderController orderController = new OrderController();
            orderController.CreateOrder(customer, physicalProduct, 2, discount, paymentMethod);

            orderController.CreateOrder(customer, digitalProduct, 5, discount, paymentMethod);
        }
    }

    class PercentageDiscount : IDiscount
    {
        private readonly decimal _percentage;
        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
        }

        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount - (totalAmount * _percentage / 100);
        }
    }

    class CreditCardPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount:C}.");
        }
    }
}

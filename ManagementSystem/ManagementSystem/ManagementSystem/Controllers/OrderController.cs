using ManagementSystemBLL.Models;
using ManagementSystemBLL.Services;
using ManagementSystemDAL.Interfaces;
using ManagementSystemDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemPL.Controllers
{
    public class OrderController
    {
        private readonly OrderEventHandler _eventHandler;
        private readonly PaymentProcessor _paymentProcessor;

        public OrderController()
        {
            _eventHandler = new OrderEventHandler();
            _paymentProcessor = new PaymentProcessor();
        }

        public void CreateOrder(Customer customer, Product product, int quantity, IDiscount discount, IPayment paymentMethod)
        {
            Order order = new Order(customer, product, quantity, discount, paymentMethod);

            if (product.IsInStock(quantity))
            {
                order.ProcessOrder();
                _eventHandler.NotifyStockDepletion(product);
            }
            else
            {
                Console.WriteLine("Insufficient stock to create order.");
            }
        }
    }
}

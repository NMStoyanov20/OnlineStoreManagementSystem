using ManagementSystemDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemBLL.Services
{
    public class OrderEventHandler
    {
        public void NotifyStockDepletion(Product product)
        {
            if (product.Stock == 0)
            {
                Console.WriteLine($"Alert: Product '{product.Name}' is out of stock.");
            }
        }
    }
}

using ManagementSystemDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemPL.Controllers
{
    public class ProductController
    {
        public void DisplayProductDetails(Product product)
        {
            product.DisplayProductDetails();
        }

        public bool IsProductInStock(Product product, int quantity)
        {
            return product.IsInStock(quantity);
        }
    }
}

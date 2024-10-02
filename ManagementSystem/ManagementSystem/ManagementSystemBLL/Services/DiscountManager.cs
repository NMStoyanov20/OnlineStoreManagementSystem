using ManagementSystemDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemBLL.Services
{
    public class DiscountManager
    {
        public decimal ApplyDiscount(IDiscount discountStrategy, decimal totalAmount)
        {
            return discountStrategy.ApplyDiscount(totalAmount);
        }
    }
}

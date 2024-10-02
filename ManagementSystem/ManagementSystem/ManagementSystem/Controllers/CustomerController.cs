using ManagementSystemBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemPL.Controllers
{
    public class CustomerController
    {
        public void DisplayCustomerInfo(Customer customer)
        {
            customer.DisplayCustomerInfo();
        }
    }
}

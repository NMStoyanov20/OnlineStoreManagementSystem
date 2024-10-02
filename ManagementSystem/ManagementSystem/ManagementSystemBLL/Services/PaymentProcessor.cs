using ManagementSystemDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemBLL.Services
{
    public class PaymentProcessor
    {
        public void ProcessPayment(IPayment paymentMethod, decimal amount)
        {
            paymentMethod.ProcessPayment(amount);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemDAL.Models
{
    public class PhysicalProduct : Product
    {
        public PhysicalProduct(string name, decimal price, int stock) : base(name, price, stock) { }

        public override void DisplayProductDetails()
        {
            Console.WriteLine($"Physical Product: {Name}, Price: {Price}, Stock: {Stock}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemDAL.Models
{
    public class DigitalProduct : Product
    {
        public DigitalProduct(string name, decimal price, int stock) : base(name, price, stock) { }

        public override void DisplayProductDetails()
        {
            Console.WriteLine($"Digital Product: {Name}, Price: {Price}, Stock: {Stock}");
        }
    }
}

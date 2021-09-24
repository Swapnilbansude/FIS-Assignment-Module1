using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var order1 = new Order();
            order1.GetOrder();
            order1.PrintOrderDetails();

            Console.ReadKey();
        }
    }
}

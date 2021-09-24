using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    class Order
    {
        //Properties of Order
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string OrderDate { get; set; }
        public string ProductName { get; set; }
        public double Price{ get; set; }
        public int Quantity { get; set; }

        //private static double orderAmount;
        public double OrderAmount {
            get 
            {
                return Price * Quantity;
            } 
        }


        //Methods of Order
        public void CalculateOrderAmount() 
        {
            Console.WriteLine($"Your order Amount is {OrderAmount}");
        }

        public void PrintOrderDetails()
        {
            Console.WriteLine("----Order Details Of Customer----");
            Console.WriteLine($"Order ID : {OrderID}");
            Console.WriteLine($"Customer Name : {CustomerName}");
            Console.WriteLine($"Order Date : {OrderDate}");
            Console.WriteLine($"Product Name : {ProductName}");
            Console.WriteLine($"Price : {Price}");
            Console.WriteLine($"Quantity : {Quantity}");
            CalculateOrderAmount();
        }

        public void GetOrder()
        {
            Console.WriteLine("----Enter your Order Details----");
            Console.WriteLine("Enter the Order ID : ");
            OrderID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Customer Name : ");
            CustomerName = Console.ReadLine();

            Console.WriteLine("Enter the Order Date : ");
            OrderDate = Console.ReadLine();

            Console.WriteLine("Enter the Product Name : ");
            ProductName = Console.ReadLine();

            Console.WriteLine("Enter the Price : ");
            Price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Quantity : ");
            Quantity = Convert.ToInt32(Console.ReadLine());
        }
    }
}

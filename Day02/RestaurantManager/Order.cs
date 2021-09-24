using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    class Order : IOrder, ICancellable
    {
        public string CustomerName { set; get; }
        public string OrderDate { set; get; }
        public double OrderAmount { set; get; }
        public int ID { get; set; }
        public string Status { get; set; }

        public void Cancel()
        {
            Status = "Cancelled";
        }

        public void Confirm()
        {
            Status = "Confirmed";
        }

        public void GetData() 
        {
            Console.WriteLine("Enter the ID : ");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Customer name : ");
            CustomerName = Console.ReadLine();

            Console.WriteLine("Enter the Order Date : ");
            OrderDate = Console.ReadLine();

            Console.WriteLine("Enter the Order Amount : ");
            OrderAmount = Convert.ToDouble( Console.ReadLine());
        }

        public void OrderDetails()
        {
            Console.WriteLine("----Order Details----");
            Console.WriteLine($"ID : {ID}");
            Console.WriteLine($"Customer Name : {CustomerName}");
            Console.WriteLine($"Order Date : {OrderDate}");
            Console.WriteLine($"Order Amount : {OrderAmount}");
            Console.WriteLine($"Order Status : {Status}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var Order = new Order();
            Order.GetData();
            int choice;
            do
            {
                Console.WriteLine("----Operation Menu----");
                Console.WriteLine("1. Confirm");
                Console.WriteLine("2. Cancel");
                Console.WriteLine("3. Order Details");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice != 4)
                {
                    switch (choice)
                    {
                        case 1:
                            Order.Confirm();
                            Console.WriteLine("Order confirmed successfully...");
                            break;
                        case 2:
                            Order.Cancel();
                            Console.WriteLine("Order cancelled successfully...");
                            break;
                        case 3:
                            Order.OrderDetails();
                            break;
                        default:
                            Console.WriteLine("Wrong choice....");
                            break;
                    }
                }
            } while (choice != 4);

        }
    }
}

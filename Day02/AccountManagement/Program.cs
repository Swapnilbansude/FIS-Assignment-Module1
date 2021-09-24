using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount SV = new SavingsAccount();
            Console.WriteLine("Enter the account no : ");
            SV.AccountNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the customer name : ");
            SV.CustomerName = Console.ReadLine();
            int choice;
            do
            {
                Console.WriteLine("----Operation Menu----");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Account Details");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice!=4)
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the amount to deposit : ");
                            double amount = Convert.ToDouble(Console.ReadLine());
                            SV.Deposit(amount);
                            Console.WriteLine("Amount deposited successfully...");
                            break;
                        case 2:
                            Console.WriteLine("Enter the amount to withdraw : ");
                            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                            SV.Withdraw(withdrawAmount);
                            break;
                        case 3:
                            SV.AccountDetails();
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XyzBankLtd
{
    class Program
    {
        static void Main(string[] args)
        {
            var AccountObj = new Account();

            Console.WriteLine("Enter the Account No : ");
            AccountObj.AccountNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Customer name : ");
            AccountObj.CustomerName = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("\n----Operation----");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Account Details");
                Console.WriteLine("4. Exit");
                Console.WriteLine("\nEnter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Enter amount to deposit :");
                            double amount = Convert.ToDouble(Console.ReadLine());
                            AccountObj.Deposit(amount);
                        }
                        catch (ArgumentException ae)
                        {
                            Console.WriteLine("Error : " + ae.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error : " + ex.Message);
                        }
                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine("Enter amount to withdraw :");
                            double amount = Convert.ToDouble(Console.ReadLine());
                            AccountObj.WithDraw(amount);
                        }
                        catch (ArgumentException ae)
                        {
                            Console.WriteLine("Error : " + ae.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error : " + ex.Message);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nAccount No\tCustomer no\tBalance");
                        Console.WriteLine(AccountObj.ToString());
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Operation...");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}

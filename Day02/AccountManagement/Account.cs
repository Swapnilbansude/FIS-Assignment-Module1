using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement
{
    abstract class Account
    {
        public int AccountNo { get; set; }
        public double Balance { get; set; }
        public string CustomerName { get; set; }

        public void Deposit(double amount) 
        {
            Balance += amount;
        }

        public void AccountDetails()
        {
            Console.WriteLine("----Account Details----");
            Console.WriteLine($"Account no : {AccountNo}");
            Console.WriteLine($"Customer name : {CustomerName}");
            Console.WriteLine($"Balance : {Balance}");
        }
        abstract public void Withdraw(double amount);
    }
}

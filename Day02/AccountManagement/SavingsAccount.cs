using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement
{
    class SavingsAccount : Account
    {
        public SavingsAccount()
        {
            Balance = 2000;
        }
        public override void Withdraw(double amount)
        {
            if (Balance - amount > 500)
            {
                Balance -= amount;
                Console.WriteLine("Amount withdraw successfully...");
            }
            else
            {
                Console.WriteLine("Operation not supported. Minimum balance must be maintained");
            }
        }
    }
}

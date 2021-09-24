using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XyzBankLtd
{
    class Account
    {
        public int AccountNo { get; set; }
        public string CustomerName { get; set; }
        
        private double balance;
        public double Balance
        { 
            get
            {
                return balance;
            }
        }


        public void WithDraw(double amount) 
        {
            if (amount > Balance)
            {
                var ar = new ArgumentException("Insufficient balance");
                throw ar;
            }
            else
            {
                balance = balance - amount;
                Console.WriteLine("Amount withdraw successfully...");
            }
            
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                var ae = new ArgumentException("Invalid value for amount");
                throw ae;
            }
            else 
            {
                balance = balance + amount;
                Console.WriteLine("Amount deposited successfully...");
            }
        }

        public override string ToString()
        {
            return $"{AccountNo}\t\t{CustomerName}\t\t{Balance}";
        }
    }
}

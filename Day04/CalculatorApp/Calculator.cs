using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculator
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public void Add(int num1, int num2)
        {
            Console.WriteLine("Addition is : " + (this.Number1 + this.Number2));
        }
        public void Subtract(int num1, int num2)
        {
            Console.WriteLine("Substraction is : " + (this.Number1 - this.Number2));
        }
        public void Multiply(int num1, int num2)
        {
            Console.WriteLine("Multiplication is : " + (this.Number1 * this.Number2));
        }
        public void Divide(int num1, int num2)
        {
            Console.WriteLine("Division is : " + (this.Number1 / Convert.ToDouble(this.Number2)));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        public delegate void CalculateHandler(int num1,int num2);
        static void Main(string[] args)
        {
            Calculator obj = new Calculator();

            Console.WriteLine("Enter the two numbers for Arithmatic operation : ");
            obj.Number1 = Convert.ToInt32(Console.ReadLine());
            obj.Number2 = Convert.ToInt32(Console.ReadLine());

            var calHandler = new CalculateHandler(obj.Add);
            calHandler += obj.Subtract;
            calHandler += obj.Multiply;
            calHandler += obj.Divide;

            Console.WriteLine("----Result of Operation----");
            calHandler(obj.Number1,obj.Number2);

            Console.ReadKey();
        }
    }
}

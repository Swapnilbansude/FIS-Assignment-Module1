using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the two values");
            int Number01 = Convert.ToInt32(Console.ReadLine());
            int Number02 = Convert.ToInt32(Console.ReadLine());
            int Choice;
            do
            {

                Console.WriteLine("----Calculator Menu----");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Substraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Please enter your choice : ");
                Choice = Convert.ToInt32(Console.ReadLine());

                if (Choice != 5)
                {
                    switch (Choice)
                    {
                        case 1:
                            Console.WriteLine($"Addition of {Number01} and {Number02} is : " + (Number01 + Number02));
                            break;
                        case 2:
                            Console.WriteLine($"Substraction of {Number01} and {Number02} is : " + (Number01 - Number02));
                            break;
                        case 3:
                            Console.WriteLine($"Multiplication of {Number01} and {Number02} is : " + (Number01 * Number02));
                            break;
                        case 4:
                            Console.WriteLine($"Division of {Number01} and {Number02} is : " + (double
                                )(Number01 / Number02));
                            break;
                    }
                }
            } while (Choice != 5);

            Console.ReadKey();
        }
    }
}

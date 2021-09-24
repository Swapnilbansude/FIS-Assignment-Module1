using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Enter the marks of Student----");

            Console.WriteLine("Enter the marks of Maths : ");
            double MathsMarks = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the marks of Physics : ");
            double PhysicsMarks = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the marks of Chemistry : ");
            double ChemistryMarks = Convert.ToDouble(Console.ReadLine());

            double Average;
            Average = TotalMarks(MathsMarks, PhysicsMarks, ChemistryMarks) / 3;

            Console.WriteLine($"Average of Student is : {Average}");

            if (Average > 90)
                Console.WriteLine("Grade is A");
            else if(Average > 80)
                Console.WriteLine("Grade is B");
            else if(Average > 70)
                Console.WriteLine("Grade is C");
            else if(Average < 35)
                Console.WriteLine("Grade is F");

            Console.ReadKey();

        }

        public static double TotalMarks(double Maths, double Physics, double Chemistry) 
        {
            return Maths + Physics + Chemistry;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = new string[10];
            bool flag = false;
            Console.WriteLine("Enter the 10 names : ");
            for (int Name = 0; Name < Names.Length; Name++) 
            {
                Names[Name] = Console.ReadLine();
            }

            Console.WriteLine("Enter the name to find : ");
            string FindName = Console.ReadLine();

            for (int Name = 0; Name < Names.Length; Name++)
            {
                if (Names[Name] == FindName)
                    flag = true;
            }

            if (flag)
                Console.WriteLine(FindName);
            else
                Console.WriteLine("Not Found");
            Console.ReadKey();

        }
    }
}

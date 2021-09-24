using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTOApplication
{
    class Program
    {
        static Dictionary<string, string> RTOTable;

        static void AddRTOData()
        {
            Console.WriteLine("Enter RTO code : ");
            string code = Console.ReadLine();

            Console.WriteLine("Enter District : ");
            string state = Console.ReadLine();

            RTOTable.Add(code,state);
            Console.WriteLine("RTO Data added successfuly...");

        }

        static void RemoveRTOData()
        {
            Console.WriteLine("Enter RTO code to delete: ");
            string code = Console.ReadLine();

            if (RTOTable.ContainsKey(code))
            {
                RTOTable.Remove(code);
                Console.WriteLine("RTO Data removed successfuly...");
            }
            else
            {
                Console.WriteLine("RTO code is not found in table");
            }

        }

        static void SearchRTOData()
        {
            Console.WriteLine("Enter RTO code to search: ");
            string code = Console.ReadLine();

            if (RTOTable.ContainsKey(code))
            {
                Console.WriteLine("RTO data found");
                Console.WriteLine("\nRTO Codes\tDistrict");
                Console.WriteLine($"{code}\t\t{RTOTable[code]}");
            }
            else
            {
                Console.WriteLine("RTO code is not found in table");
            }

        }

        static void RTOTableData()
        {
            Console.WriteLine("\nRTO Codes\tDistrict");
            foreach (var key in RTOTable.Keys)
            {
                Console.WriteLine($"{key}\t\t{RTOTable[key]}");
            }
        }
        static void Main(string[] args)
        {
            RTOTable = new Dictionary<string,string>();
            while (true)
            {
                Console.WriteLine("----RTO Dictionary Operation----");
                Console.WriteLine("\n1. Add RTO code and district name");
                Console.WriteLine("2. List RTO Details");
                Console.WriteLine("3. Remove By RTO code");
                Console.WriteLine("4. Search RTO data By RTO code");
                Console.WriteLine("5. Exit");
                Console.WriteLine("\nEnter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddRTOData();
                        break;
                    case 2:
                        RTOTableData();
                        break;
                    case 3:
                        RemoveRTOData();
                        break;
                    case 4:
                        SearchRTOData();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

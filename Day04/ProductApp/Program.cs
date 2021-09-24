using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ProductData = GetProducts();
            int choice = -1;
            // AllProductDetails(ProductData);
            //ProductsOrderByName(ProductData);
            //ElectronicsProducts(ProductData);
            //ProductsInYear2021(ProductData);

            while (true)
            {
                Console.WriteLine("\t\t--Menu--\n");
                Console.WriteLine("1. All Product Details");
                Console.WriteLine("2. All Products Order By Name");
                Console.WriteLine("3. All Electronics Products within price range 1000 to 2000");
                Console.WriteLine("4. All products created in 2021");
                Console.WriteLine("5. Exit");
                Console.WriteLine("\nEnter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AllProductDetails(ProductData);
                        break;
                    case 2:
                        ProductsOrderByName(ProductData);
                        break;
                    case 3:
                        ElectronicsProducts(ProductData);
                        break;
                    case 4:
                        ProductsInYear2021(ProductData);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice...");
                        break;
                }
            }

            Console.ReadKey();
        }

        static void AllProductDetails(List<Product> ProductData)
        {
            
            Console.WriteLine("\t\t----All Products Details----\n");
            var Query = from obj in ProductData
                        select obj;
            foreach (var item in Query)
            {
                Console.WriteLine(item);
            }
        }

        static void ProductsOrderByName(List<Product> ProductData)
        {
            Console.WriteLine("\t\t----All Products Details Order By Name----\n");
            var Query = from obj in ProductData
                        orderby obj.Name
                        select obj;

            foreach (var item in Query)
            {
                Console.WriteLine(item);
            }
        }
        static void ElectronicsProducts(List<Product> ProductData)
        {
            Console.WriteLine("\t\t----Electronics Product and price range from 1000 to 2000----\n");
            var Query = from obj in ProductData
                        where obj.Category == "Electronics" && (obj.Price >= 1000 && obj.Price<2000)
                        select obj;

            foreach (var item in Query)
            {
                Console.WriteLine(item);
            }
        }

        static void ProductsInYear2021(List<Product> ProductData)
        {
            Console.WriteLine("\t\t----All Products created in year 2021----\n");
            var Query = from obj in ProductData
                        where obj.CreatedOn.Year == 2021
                        select obj;

            foreach (var item in Query)
            {
                Console.WriteLine(item);
            }
        }
        static List<Product> GetProducts()
        {
            var productList = new List<Product>()
            {
                new Product(101,"Pendrive",1100,"Electronics",new DateTime(2021,01,1)),
                new Product(102,"Wireless Keyboard",3000,"Electronics",new DateTime(2020,12,12)),
                new Product(103,"Wireless Mouse",1500,"Electronics",new DateTime(2021,02,12)),
                new Product(104,"Formal shoes",3000,"Footwear",new DateTime(2021,01,10)),
                new Product(105,"Formal shirt",2200,"Clothing",new DateTime(2020,12,1)),
            };

            return productList;
        }
    }
}

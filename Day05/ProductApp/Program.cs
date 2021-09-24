using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ProductApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int Choice = -1;

            while (true)
            {
                Console.WriteLine("\t\t----Products Menu----");
                Console.WriteLine("\n1. Add a new product");
                Console.WriteLine("2. Search a product by Id");
                Console.WriteLine("3. Delete a product");
                Console.WriteLine("4. Display all product(Disconnected structure)");
                Console.WriteLine("5. Exit");
                Console.WriteLine("\nEnter your choice : ");
                Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1: AddProduct(); break;
                    case 2: SearchProduct(); break;
                    case 3: DeleteProduct(); break;
                    case 4: DisplayProduct(); break;
                    case 5: Environment.Exit(0); break;
                    default:
                        Console.WriteLine("Invalid choice...");
                        break;
                }
            }
            
            Console.ReadKey();
        }

        private static void DisplayProduct()
        {
            var ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (var Connection = new SqlConnection(ConnectionString))
            {
                try
                {                    

                    var Query = "select * from Products";

                    var Adaptor = new SqlDataAdapter(Query, Connection);

                    var DataSetObj = new DataSet("ProductDB");
                    Adaptor.Fill(DataSetObj,"Products");

                    //Console.WriteLine($"Data set name ={DataSetObj.DataSetName}");
                    //Console.WriteLine($"Table count = {DataSetObj.Tables.Count}");
                    //Console.WriteLine($"Table name = {DataSetObj.Tables[0].TableName}");
                    //Console.WriteLine($"Rows Count = {DataSetObj.Tables[0].Rows.Count}");
                    //Console.WriteLine($"Columns Count = {DataSetObj.Tables[0].Columns.Count}");

                    DataTable table = DataSetObj.Tables["Products"];
                    foreach (DataColumn column in table.Columns)
                        Console.Write(column.ColumnName + " | ");

                    foreach (DataRow row in table.Rows)
                    {
                        Console.WriteLine();
                        for (int Index = 0; Index < table.Columns.Count; Index++)
                            Console.Write(row[Index] + " | ");
                    }
                    Console.WriteLine();

                }
                catch (SqlException sx)
                {
                    Console.WriteLine(sx.Message);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Connection.Close();

                }

            }
        }

        private static void DeleteProduct()
        {
            var ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (var Connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    Console.WriteLine("Enter the ID of product to delete : ");
                    int IdToDelete = Convert.ToInt32(Console.ReadLine());

                    var Query = $"delete from Products where ID={IdToDelete}";

                    var Command = new SqlCommand(Query, Connection);
                    Connection.Open();
                    int Rows = Command.ExecuteNonQuery();

                    if (Rows > 0)
                    {
                        Console.WriteLine($"{Rows} row: affected");
                        Console.WriteLine("Product deleted successfully...\n");
                    }
                    else
                    {
                        Console.WriteLine("Product not found..");
                    }
                }
                catch (SqlException sx)
                {
                    Console.WriteLine(sx.Message);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Connection.Close();

                }

            }
        }

        private static void SearchProduct()
        {
            var ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (var Connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    Console.WriteLine("Enter ID of product to search : ");
                    int IDToSearch = Convert.ToInt32(Console.ReadLine());

                    var Query = $"select * from Products where ID={IDToSearch}";

                    var Command = new SqlCommand(Query, Connection);
                    Connection.Open();

                    SqlDataReader Data = Command.ExecuteReader();
                    
                    if (Data.HasRows)
                    {
                        int ID; string Name; double Price; string Description; bool IsActive;
                        while (Data.Read())
                        {
                            ID = Data.GetInt32(0);
                            Name = Data.GetString(1);
                            Price = Data.GetDouble(2);
                            Description = Data.GetString(3);
                            IsActive = Data.GetBoolean(4);
                            Console.WriteLine("\t\tProduct found");
                            Console.WriteLine($"ID={ID}, Name={Name}, Price={Price}, Description={Description}, IsActive={IsActive}");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Product not found...");
                    }
                }
                catch (SqlException sx)
                {
                    Console.WriteLine(sx.Message);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Connection.Close();
                }

            }
        }

        private static void AddProduct()
        {
            var ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (var Connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    Console.WriteLine("Enter the ID of product : ");
                    int Id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the product name : ");
                    string Name = Console.ReadLine();

                    Console.WriteLine("Enter the price of product : ");
                    double Price = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the description of product : ");
                    string Description = Console.ReadLine();

                    Console.WriteLine("Is active : ");
                    bool IsActive = Convert.ToBoolean(Console.ReadLine());

                    var Query = $"insert into Products values ({Id},'{Name}',{Price},'{Description}','{IsActive}')";

                    var Command = new SqlCommand(Query, Connection);
                    Connection.Open();
                    int Rows = Command.ExecuteNonQuery();
                    Console.WriteLine($"{Rows} row: affected");
                    Console.WriteLine("Product inserted successfully...\n");
                }
                catch (SqlException sx)
                {
                    Console.WriteLine(sx.Message);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Connection.Close();
                    
                }

            }
        }
    }
}

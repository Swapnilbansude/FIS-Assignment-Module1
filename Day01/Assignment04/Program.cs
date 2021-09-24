using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Matrix = new int[2, 2];
            int[,] TransposeMatrix = new int[2, 2];

            Console.WriteLine("Enter the elements of matrix");
            for (int RowIndex = 0; RowIndex < Matrix.GetLength(0); RowIndex++) 
            {
                for (int ColumnIndex = 0; ColumnIndex < Matrix.GetLength(1); ColumnIndex++)
                {
                    Console.WriteLine($"Enter value for Row {RowIndex} and Column {ColumnIndex} : ");
                    Matrix[RowIndex, ColumnIndex] = Convert.ToInt32(Console.ReadLine());
                    TransposeMatrix[ColumnIndex, RowIndex] = Matrix[RowIndex,ColumnIndex];
                }
            }

            Console.WriteLine("Original matrix");
            for (int RowIndex = 0; RowIndex < Matrix.GetLength(0); RowIndex++)
            {
                for (int ColumnIndex = 0; ColumnIndex < Matrix.GetLength(1); ColumnIndex++)
                {
                    Console.Write(Matrix[RowIndex,ColumnIndex] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Transpose matrix");
            for (int RowIndex = 0; RowIndex < TransposeMatrix.GetLength(0); RowIndex++)
            {
                for (int ColumnIndex = 0; ColumnIndex < TransposeMatrix.GetLength(1); ColumnIndex++)
                {
                    Console.Write(TransposeMatrix[RowIndex, ColumnIndex] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

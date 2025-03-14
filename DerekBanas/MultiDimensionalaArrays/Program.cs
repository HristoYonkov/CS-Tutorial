using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,,] table = new int[3, 5, 7]; Example of multi dimensional arrays.

            int[,] table = new int[3, 5];

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    table[row, col] = row + col;
                }
            }

         //example of how to get length of specific dimension..
            for (int row = 0; row < table.GetLength(0); row++)
            {
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    Console.Write(table[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


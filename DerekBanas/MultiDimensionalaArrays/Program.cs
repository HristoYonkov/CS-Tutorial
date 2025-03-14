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

            // Declare a jagged array with 3 rows
            int[][] newTable = new int[3][];

            // Initializing rows with different lengths
            newTable[0] = new int[] { 1, 2, 3 };  // Row 0: 3 elements
            newTable[1] = new int[] { 4, 5 };     // Row 1: 2 elements
            newTable[2] = new int[] { 6, 7, 8, 9 }; // Row 2: 4 elements

            // Print the jagged array
            for (int i = 0; i < newTable.Length; i++)
            {
                Console.WriteLine($"Row {i}: {string.Join(", ", newTable[i])}");
            }

            int[] myArr = new int[] { 1, 2, 3, 4, 5 };
            myArr[2]++;
            Console.WriteLine("Hello: " + myArr[2]);
        }
    }
}


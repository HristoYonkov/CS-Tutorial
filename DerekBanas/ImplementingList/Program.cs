using System;
using CustomList;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.Add(1);
            list.Add(10);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            list.Print(); // shows the state of the our List

            list.RemoveAt(0);
            list.RemoveAt(0);
            list.RemoveAt(0);
            list.Swap(0, 1);
            list.Print();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }
    }
}

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfStrings = new DoublyLinkedList<string>();
            listOfStrings.AddFirst("Ivo");
            listOfStrings.AddFirst("Pavel");
            listOfStrings.AddLast("Ani");
            listOfStrings.AddFirst("Hristo");
            Console.WriteLine(string.Join(", ", listOfStrings.ToArray()));
            listOfStrings.ForEach(x => Console.WriteLine(": " + x));


            var list = new DoublyLinkedList<int>();
            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);
            list.AddLast(4);
            list.AddFirst(0);
            list.AddLast(100);
            // 0-1-2-3-4-100
            list.RemoveFirst();
            // 1-2-3-4-100
            list.RemoveLast();
            // 1-2-3-4
            list.AddLast(5);
            // 1-2-3-4-5
            Console.WriteLine(list.Count2);
            Console.WriteLine(string.Join(", ", list.ToArray())); // 1, 2, 3, 4, 5

            list.ForEach(x => Console.WriteLine(": " + x)); // We can also pass lambda function isntead of "PrintToConsole()".

            //static void PrintToConsole(int i)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}

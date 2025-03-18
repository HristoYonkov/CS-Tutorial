using System;

namespace MyApp
{
    internal class Program
    {
        static long Multiply(int a, int b)
        {
            return a * b;
        }
        static void PrintResult(int a, int b, Func<int, int, long> func) // this typing is called "delegate" "Func<int, int, long>" last argument is what function will return.
        {
            var result = func(a, b);
            Console.WriteLine(new string('=', 50));
            Console.WriteLine($"Result: {result}");
            Console.WriteLine(new string('=', 50));
        }

        static List<int> WhereTwo(List<int> list, Func<int, bool> condition)
        {
            List<int> newList = new List<int>();
            foreach (var item in list)
            {
                if (condition(item))
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

        static void Main(string[] args)
        {
            PrintResult(2, 3, Multiply);
            //Action<int, int, long> // Action is using for void functions instead of Func which returns a value In following case Action will accept 3 parameters instead of 2 like Func, and is also "delegate".

            // LINQ examples below. More LINQ methods: Where(), Select(),OrderBy(), GroupBy(), Aggregate(), Range(), ... Check them in documentation.
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var newList = list.Where(x => x % 2 == 0); // Predicate == Function which returning true or false.
            var newList = WhereTwo(list, x => x % 3 == 0); // Our created version of "Where()" LINQ method.
            Console.WriteLine(string.Join(", ", newList));
        }
    }
}

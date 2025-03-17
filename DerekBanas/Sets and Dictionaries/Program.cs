using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var names = new SortedDictionary<string, int>(); // Dictionary with sorted keys.
            var names = new Dictionary<string, int>();
            names["Niki"] = 3;
            names.Add("Stoyan", 2); // names["Stoyan"] = 2;
            names.Remove("Stoyan");
            if (names.ContainsKey("Viki")) // In order to check if a key exist we use ContainsKey() method. otherwise if we do not check there will be error with the program.
            {
                Console.WriteLine(names["Viki"]);
            }

            names["Viktor"] = 4;
            names["Ivo"] = 1;
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            // We also have ContainsValue() method but it is a very slow operation, so we may want to avoid this if we can.
        }
    }
}

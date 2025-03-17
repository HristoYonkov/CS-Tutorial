using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"C:\Temp\output.txt");
            sw.WriteLine("Hello!!!");
            sw.Close();
        }
    }
}

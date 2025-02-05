using System;

namespace Intro
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[,] customerNames = new string[2, 2] { {"Hristo", "Yonkov"}, { "Pavel", "Dimitrov"} };
            Console.WriteLine($"MD Value : {customerNames.GetValue(0, 0)}");
        }
    }
}

using System;
using System.Globalization;
using System.Text;

namespace MyApp
{
    internal class Program
    {
        // Exeption handling..
        //static double DoDivision(double x, double y)
        //{
        //    if (y == 0)
        //    {
        //        throw new System.DivideByZeroException();
        //    }
        //    return x / y;
        //}
        // Exeption handling..
 //-----------------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            // "do while" loop example..

            //Random rand = new Random();
            //int secretNumber = rand.Next(1, 5);
            //int numberGuessed = 0;
            //Console.WriteLine("Random number: ", secretNumber);

            //do
            //{
            //    Console.WriteLine("Enter a number between 1 and 5: ");
            //    numberGuessed = Convert.ToInt32(Console.ReadLine());
            //} while (secretNumber != numberGuessed);

            //Console.WriteLine($"You guessed, a number is {numberGuessed}");
            //Console.ReadLine();

            // "do while" loop example..
            //---------------------------------------------------------------------------------

            // Exeption handling..

            //double num1 = 5;
            //double num2 = 0;

            //try
            //{
            //    Console.WriteLine($"5/0 = {DoDivision(num1, num2)}");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("You cant divide by 0.");
            //    Console.WriteLine(ex.GetType().Name);
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An error occurred.");
            //    Console.WriteLine(ex.GetType().Name);
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Cleaning Up");
            //}
            //Console.ReadLine();

            // Exeption handling..
            //-------------------------------------------------------------------------------------------

            //String builders..

            //StringBuilder sb = new StringBuilder("Some text.");
            //StringBuilder sb2 = new StringBuilder("More stuff that is very important", 256);
            //Console.WriteLine("Capacity: {0}", sb2.Capacity);
            //Console.WriteLine("Length: {0}", sb2.Length);
            //sb2.AppendLine("\nMore important text");
            //CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
            //string bestCust = "Bob Smith";
            //sb2.AppendFormat(enUS, $"Best customer: {bestCust}");
            //Console.WriteLine(sb2.ToString());
            //sb2.Replace("text", "characters");
            //Console.WriteLine(sb2.ToString());
            //sb2.Clear();
            //sb2.Append("Random Text");
            //Console.WriteLine(sb.Equals(sb2));
            //sb2.Insert(11, " that's great");
            //Console.WriteLine(sb2.ToString());
            //sb2.Remove(11, 7);
            //Console.WriteLine(sb2.ToString());

            //String builders..
            //-------------------------------------------------------------------------------------------

            // Datetime timespans..

            DateTime awesomeDate = new DateTime(1990, 04, 28);
            Console.WriteLine("Day of week : {0}", awesomeDate.DayOfWeek);
            awesomeDate = awesomeDate.AddDays(2);
            awesomeDate = awesomeDate.AddMonths(1);
            awesomeDate = awesomeDate.AddYears(1);
            Console.WriteLine("New Date : {0}", awesomeDate.Date);

            TimeSpan lunchTime = new TimeSpan(12, 30, 00);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            Console.WriteLine("New Time : {0}", lunchTime);

            // Datetime timespans..

        }
    }
}

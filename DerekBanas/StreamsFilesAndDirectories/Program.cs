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

            StreamReader sr = new StreamReader(@"C:\Temp\countries.txt");
            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadLine());
            sr.Close();

            //Here we can read and write with byte numbers.
            FileStream fileStreamRead = new FileStream(@"C:\Temp\output.txt", FileMode.OpenOrCreate);
            byte[] buffer = new byte[100];
            fileStreamRead.Read(buffer, 0, 25);

            //Writing values
            FileStream fileStreamWrite = new FileStream(@"C:\Temp\outputWrite.txt", FileMode.OpenOrCreate);
            byte[] data = new byte[] { 72, 85, 73 };
            fileStreamWrite.Write(data, 0, data.Length);
            fileStreamWrite.Close();

            //ReaderWriterLock exact values
            byte[] read = new byte[2];
            fileStreamRead.Seek(2, SeekOrigin.Begin); // Set pointer at the third position of the array.
            fileStreamRead.Read(read, 0, 2); // Will read "ll".

            //Another usefull methods that we can use and make operations on 1 row of codes are:
            string fileContent = File.ReadAllText("someFile.txt"); // we need to have this file
            string[] fileContent2 = File.ReadAllLines("someFile.txt"); // we need to have this file
            File.WriteAllText(@"C:\Temp\All.txt", "Sentence inside the file."); //Create the file and put the text inside the file.

            var arrOfStrings = new string[] { "Line1", "Line2", "Line3" };
            File.WriteAllLines(@"C:\Temp\Lines.txt", arrOfStrings); // Create a file with n count of text rows.
            File.AppendAllText(@"C:\Temp\Lines.txt", "Added new Line."); // Opens the file and add new lines of text.

            //We also can use direcories length of directories but for that need just check the google or lection again.
        }
    }
}

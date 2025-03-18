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
            fileStreamRead.Read(read, 0, 2); // Will read "ll"
        }
    }
}

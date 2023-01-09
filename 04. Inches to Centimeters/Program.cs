using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double cm = 2.54;

            double sum = inches * cm;
            Console.WriteLine(sum);
        }
    }
}

using System;

namespace YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double property = double.Parse(Console.ReadLine());
            double squareMeters = property * 7.61;
            double discount = (squareMeters * 0.18);
            double finalsum = squareMeters - discount;
            Console.WriteLine($"The final price is {finalsum} lv.");
            Console.WriteLine($"The discount is {discount} lv. ");
        }
    }
}

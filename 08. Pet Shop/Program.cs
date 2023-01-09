using System;

namespace PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            double dogfood = (2.5 * dogs);
            int cats = int.Parse(Console.ReadLine());
            double catsfood = (4.00 * cats);

            double sum = dogfood + catsfood;
            Console.WriteLine(sum + " lv.");

        }
    }
}

﻿using System;

namespace ProjectsCreation2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            double hours = projects * 3;
            Console.WriteLine($"The architect {name} will need {hours} hours to complete {projects} project/s.");

        }
    }
}

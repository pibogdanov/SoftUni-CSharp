﻿using System;

namespace _04.EvenPowersOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numbersCount; i += 2)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}

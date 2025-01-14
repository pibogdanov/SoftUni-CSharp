﻿using System;

namespace _09.LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine()); 

            int sumRight = 0;

            int sumLeft = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                sumRight += number;
            }

            for (int j = 0; j < numbersCount; j++)
            {
                int number = int.Parse(Console.ReadLine());

                sumLeft += number;
            }

            if (sumRight == sumLeft)
            {
                Console.WriteLine($"Yes, sum = {sumRight}");
            }

            else
            {
                int difference = Math.Abs(sumRight - sumLeft);
                Console.WriteLine($"No, diff = {difference}");
            }
        }
    }
}

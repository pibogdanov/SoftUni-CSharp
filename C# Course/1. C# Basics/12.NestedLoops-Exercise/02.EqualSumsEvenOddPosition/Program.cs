﻿using System;

namespace _02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());

            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                string currentNumber = i.ToString();

                int evenSum = 0;

                int oddSum = 0;

                for (int j = 0; j < currentNumber.Length; j++)
                {
                    int currentDigit = int.Parse(currentNumber[j].ToString());

                    if (j % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }

                    else
                    {
                        oddSum += currentDigit;
                    }
                }

                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}

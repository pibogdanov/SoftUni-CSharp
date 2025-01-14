﻿using System;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTopNumbersUpTo(number);
        }

        static void PrintTopNumbersUpTo(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if ( (IsDigitSumDivisibleBy8(i)) && (HasOddDigit(i)) )
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool HasOddDigit(int number)
        {
            while (number > 0)
            {
                if (number % 10 % 2 != 0)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }

        static bool IsDigitSumDivisibleBy8(int number)
        {
            int digitSum = 0;

            while (number > 0)
            {
                digitSum += number % 10;

                number /= 10;
            }

            if (digitSum % 8 == 0)
            {
                return true;
            }

            return false;
        }
    }
}

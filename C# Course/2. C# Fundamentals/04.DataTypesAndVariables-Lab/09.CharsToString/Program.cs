﻿using System;

namespace _09.CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());

            char secondChar = char.Parse(Console.ReadLine());

            char thirdChar = char.Parse(Console.ReadLine());

            string result = Char.ToString(firstChar) + Char.ToString(secondChar) + Char.ToString(thirdChar);
            Console.WriteLine(result);
        }
    }
}

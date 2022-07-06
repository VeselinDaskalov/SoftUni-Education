﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            int[] items = new int[numberOfNumbers];

            for (int i = 0; i < numberOfNumbers; i++)
            {
                items[i] = int.Parse(Console.ReadLine());
            }

            for (int i = items.Length-1; i >= 0 ; i--)
            {
                Console.Write($"{items[i]} ");
            }

            //Console.WriteLine(String.Join(" ", items));  the same like upper  
        }
    }
}
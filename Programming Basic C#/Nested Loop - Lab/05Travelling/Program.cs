﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                    break;

                double expences = double.Parse(Console.ReadLine()), savings = 0;

                while (savings < expences)
                {
                    double money = double.Parse(Console.ReadLine());
                    savings += money;
                }

                Console.WriteLine($"Going to {destination}!");
        }   }
    }
}

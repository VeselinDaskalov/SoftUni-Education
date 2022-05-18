using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());
            double salary = 0.00;


            if (kilometers <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    salary = kilometers * 0.75;
                }
                else if (season == "Summer")
                {
                    salary = kilometers * 0.90;
                }
                else if (season == "Winter")
                {
                    salary = kilometers * 1.05;
                }
            }
            else if (kilometers > 5000 && kilometers <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    salary = kilometers * 0.95;
                }
                else if (season == "Summer")
                {
                    salary = kilometers * 1.10;
                }
                else if (season == "Winter")
                {
                    salary = kilometers * 1.25;
                }
            }
            else if (kilometers > 10000 && kilometers <= 20000)
            {
                salary = kilometers * 1.45;
            }
            salary = salary * 4;
            double salaryAfterTax = salary - salary * 0.10;
            Console.WriteLine($"{salaryAfterTax:f2}");
        }
    }
}

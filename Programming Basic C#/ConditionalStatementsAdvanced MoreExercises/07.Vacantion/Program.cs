using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacantion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string inTo = "";
            string location = "";
            double price = 0.00;

            if (budget <= 1000)
            {
                inTo = "Camp";
                if(season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.45;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                inTo = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.80;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.60;
                }
            }
            else if (budget > 3000)
            {
                inTo = "Hotel";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.90;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.90;
                }
            }
            Console.WriteLine($"{location} - {inTo} - {price:f2}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarToGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0.00;
            string clasCar = "";
            string typeCar = "";

            if (budget <= 100)
            {
                clasCar = "Economy class";
                if (season == "Summer")
                {
                    typeCar = "Cabrio";
                    price = budget * 0.35;

                }
                else if (season == "Winter")
                {
                    typeCar = "Jeep";
                    price = budget * 0.65;
                }

            }
            else if (budget > 100 && budget <= 500)
            {
                clasCar = "Compact class";
                if (season == "Summer")
                {
                    typeCar = "Cabrio";
                    price = budget * 0.45;
                }
                else if (season == "Winter")
                {
                    typeCar = "Jeep";
                    price = budget * 0.80;
                }
            }
            else if (budget > 500)
            {
                clasCar = "Luxury class";
                typeCar = "Jeep";
                price = budget * 0.90;
            }
            Console.WriteLine($"{clasCar}");
            Console.WriteLine($"{typeCar} - {price:f2}");

        }
    }
}

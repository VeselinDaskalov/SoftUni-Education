using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();   
            int people = int.Parse(Console.ReadLine());
            double transportPrice = 0.0;


            if (people >= 1 && people <= 4)
            {
                transportPrice = budget * 0.75;
            }
            else if (people >= 5 && people <= 9)
            {
                transportPrice = budget * 0.60;
            }
            else if (people >= 10 && people <= 24)
            {
                transportPrice = budget * 0.50;
            }
            else if (people >= 25 && people <= 49)
            {
                transportPrice = budget * 0.40;
            }
            else
            {
                transportPrice = budget * 0.25;
            }

            double moneyLeft = budget - transportPrice;
            double ticket = category == "VIP" ? 499.99 : 249.99;
            double moneyForTickets = ticket * people;
            double left = Math.Abs(moneyLeft - moneyForTickets);

            if (moneyForTickets <= moneyLeft)
            {
                Console.WriteLine("Yes! You have {0:F2} leva left.", left);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", left);
            }
        }
    }
}

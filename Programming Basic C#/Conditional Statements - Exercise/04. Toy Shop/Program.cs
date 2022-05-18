using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceExcursion = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());    
            int dollsTalking = int.Parse(Console.ReadLine());   
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine()); 
            double totalSum = 0;
            double totalSum1 = 0;
            double discount = 0;
            double rent = 0;

            double sum = puzzles * 2.60 + dollsTalking * 3 + teddyBears * 4.10 + minions * 8.20 + trucks * 2;
            int toys = puzzles + dollsTalking + teddyBears + minions + trucks;

            if (toys >= 50)
            {
                discount = 0.25 * sum;
                totalSum = sum - discount;
                rent = 0.10 * totalSum;
                totalSum1 = totalSum - rent;
            }
            else
            {
                totalSum = sum;
                rent = 0.10 * totalSum;
                totalSum1 = totalSum - rent;
            }
            if (totalSum1 >= priceExcursion)
            {
                Console.WriteLine($"Yes! {(totalSum1 - priceExcursion):f2} lv left.");
            }
            else
                Console.WriteLine($"Not enough money! {(priceExcursion - totalSum1):f2} lv needed.");
        }
    }
}

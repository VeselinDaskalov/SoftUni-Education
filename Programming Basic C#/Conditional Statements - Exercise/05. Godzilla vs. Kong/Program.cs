using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budgetMovie = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine()); 
            double clothingPriceForOneStatist = double.Parse(Console.ReadLine());
            double decorPrice = budgetMovie * 0.10;
            double priceForCloth = clothingPriceForOneStatist * statist;

            if (statist > 150)
            {
                priceForCloth = priceForCloth - (priceForCloth * 0.1);
            }
            double filmPrice = priceForCloth + decorPrice;
            if (filmPrice <= budgetMovie)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budgetMovie - filmPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budgetMovie - filmPrice):f2} leva more.");
            }
        }
    }
}

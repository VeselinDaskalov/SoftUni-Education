using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double priceOfSaber = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double totalNumbersOfSablers = Math.Ceiling(studentCount * 1.10);
            double numberOfFreeBelts = Math.Floor(studentCount / 6.0);
            double finalPriceForSabers = totalNumbersOfSablers * priceOfSaber;
            double finalPriceForRobes = studentCount * priceOfRobes;
            double finalPriceForBelts = (studentCount - numberOfFreeBelts) * priceOfBelts;

            double totalFinalPrice = finalPriceForSabers + finalPriceForRobes + finalPriceForBelts;

            if (budget >= totalFinalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalFinalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(totalFinalPrice -budget):f2}lv more.");
            }



        }
    }
}

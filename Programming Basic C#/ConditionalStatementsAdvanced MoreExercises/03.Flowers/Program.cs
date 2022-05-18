using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numChrysanthemums = int.Parse(Console.ReadLine());
            int numRosses = int.Parse(Console.ReadLine());
            int numTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string isHoliday = Console.ReadLine();           

            double priceChrysanthemums = 0.00, priceRosses = 0.00, priceTulips = 0.00;           

            if (season == "Spring" || season == "Summer")
            {
                priceChrysanthemums = 2.00 * numChrysanthemums;
                priceRosses = 4.10 * numRosses;
                priceTulips = 2.50 * numTulips;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                priceChrysanthemums = numChrysanthemums * 3.75;
                priceRosses = numRosses * 4.50;
                priceTulips = numTulips * 4.15;
            }
            double totalPrice = priceChrysanthemums + priceRosses + priceTulips;

            if(numTulips > 7 && season == "Spring")
            {
                totalPrice = totalPrice * 0.95;
            }
            else if (numRosses >= 10 && season == "Winter")
            {
                totalPrice = totalPrice * 0.9;
            }
            if (isHoliday == "Y")
            {
                totalPrice *= 1.15;
            }
            if(numRosses + numTulips + numChrysanthemums >= 20)
            {
                totalPrice *= 0.80;
            }
            Console.WriteLine(string.Format("{0:f2}", totalPrice + 2));
            Console.ReadLine();
        }
    }
}

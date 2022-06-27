using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headstePrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayProce = double.Parse(Console.ReadLine());

            int countHeadsetTrashes = lostGamesCount / 2;
            int countMouseTrashes = lostGamesCount / 3;
            int countKeyboardTrashes = lostGamesCount / 6;
            int countDisplayTrashes = lostGamesCount / 12;

            double priceHeadsetTrashes = headstePrice * countHeadsetTrashes;
            double priceMouseTrashes = mousePrice * countMouseTrashes;
            double priceKeyboardTrashes = keyboardPrice * countKeyboardTrashes;
            double priceDisplayTrashes = displayProce * countDisplayTrashes;

            double expenses = priceHeadsetTrashes + priceMouseTrashes + priceKeyboardTrashes + priceDisplayTrashes;

            Console.WriteLine($"Rage expenses: {expenses:f2} lv."); 


        }
    }
}

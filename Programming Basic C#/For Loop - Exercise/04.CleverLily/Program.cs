using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());    
            double washingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            //когато i  е четно => i % 2 == 0 => i*5-1
            //когато i  е нечетно => i % 2 != 0 => получава играчка toyPrice
            double money = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money = money + i * 5 - 1;
                }
                else
                {
                    money = money + toyPrice;
                }
            }
            if (money >= washingMachine)
            {
                Console.WriteLine($"Yes! {money - washingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachine - money:f2}");
            }


        }

    }
}

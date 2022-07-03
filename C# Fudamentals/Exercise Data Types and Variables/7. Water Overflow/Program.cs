using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            const int WATERTANK = 255;
            int waterLevel = 0;
            for (int i = 0; i < n; i++)
            {
                int quatityOfWater = int.Parse(Console.ReadLine());

                if (waterLevel + quatityOfWater > WATERTANK)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    waterLevel += quatityOfWater;
                }
            }
            Console.WriteLine(waterLevel);




        }
    }
}

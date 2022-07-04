using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());

            double biggestKeg = double.MinValue;
            string biggesKegName = string.Empty;

            for (int i = 0; i < nLines; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int hight = int.Parse(Console.ReadLine());

                double volumeOfTheCurrentKeg = Math.PI * Math.Pow(radius, 2) * hight;

                if (volumeOfTheCurrentKeg > biggestKeg)
                {
                    biggestKeg = volumeOfTheCurrentKeg;
                    biggesKegName = model;

                }
            }

            Console.WriteLine(biggesKegName);
        }
    }
}

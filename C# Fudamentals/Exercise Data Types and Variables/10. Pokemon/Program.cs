using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhustionFactor = int.Parse(Console.ReadLine());
            int startingPower = power;
            int countOfPokedTargets = 0;

            while (power >= distance)
            {
                power -= distance;
                countOfPokedTargets++;
                if (startingPower * 0.5 == power && exhustionFactor > 0)
                {
                    power /= exhustionFactor;
                }
            }

            Console.WriteLine(power);
            Console.WriteLine(countOfPokedTargets);

        }
    }
}

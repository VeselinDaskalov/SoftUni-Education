using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int episode = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double lunch = breakTime / 8.0;
            double rest = breakTime / 4.0;
            double time = breakTime - lunch - rest;

            


            if (time >= episode)
            {
                double resultTime = Math.Ceiling(time - episode);
                Console.WriteLine($"You have enough time to watch {name} and left with {resultTime} minutes free time.");
            }
            else
            {
                double neededTime = Math.Ceiling(episode - time);
                Console.WriteLine($"You don't have enough time to watch {name}, you need {neededTime} more minutes.");
            }
        }
    }
}

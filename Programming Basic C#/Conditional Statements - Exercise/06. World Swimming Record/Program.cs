using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double time1 = distance * time;
            double distanceDelay = distance / 15.0;
            double timeDelay = Math.Floor(distanceDelay) * 12.5;
            double newTime = time1 + timeDelay;

            if (newTime >= record)
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(newTime - record):f2} seconds slower.");
            }
            else if (newTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {newTime:f2} seconds.");
            }
        }
    }
}

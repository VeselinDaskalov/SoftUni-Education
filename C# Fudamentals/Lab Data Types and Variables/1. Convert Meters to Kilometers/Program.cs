using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            double kilometers = meters / 1000d;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}

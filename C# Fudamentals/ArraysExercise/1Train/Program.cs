using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());

            int sum = 0;

            int[] peopleInWagon = new int[numberOfWagons];
            for (int i = 0; i < numberOfWagons; i++)
            {
                peopleInWagon [i] = int.Parse(Console.ReadLine());

                sum += peopleInWagon[i];
            }
            Console.WriteLine(String.Join(" ", peopleInWagon));
            Console.WriteLine(sum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberCoppy = number;
            int sum = 0;

            // 145 => 1, 4, 5

            while (number > 0)
            {
                int factorialNumber = 1;
                int currNumber = number % 10;
                number /= 10;

                for (int i = 2; i <= currNumber; i++)
                {
                    factorialNumber *= i;
                }
                sum += factorialNumber;
            }
            Console.WriteLine(sum == numberCoppy ? "yes" : "no");

        }
    }
}

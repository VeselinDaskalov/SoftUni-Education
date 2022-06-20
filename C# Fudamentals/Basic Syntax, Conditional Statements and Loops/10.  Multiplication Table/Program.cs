using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplication = 0;

            for (int i = 1; i <= 10; i++)
            {
                multiplication = number * i;
                Console.WriteLine($"{number} X {i} = {multiplication}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());
            //long sum = 0;

            //for (int i = 0; i < number; i++)
            //{
            //    char ch = char.Parse(Console.ReadLine());
            //    sum += (int)ch;
            //}

            //Console.WriteLine($"The sum equals: {sum}");

            int number = int.Parse(Console.ReadLine());
            int finalSum = 0;
            for (int i = 0; i < number; i++)
            {
                char digit = char.Parse(Console.ReadLine());
                finalSum += (int)digit;
            }

            Console.WriteLine($"The sum equals: {finalSum}");
        }
    }
}

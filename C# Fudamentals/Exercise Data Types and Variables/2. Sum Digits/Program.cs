using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());
            //int sum = 0;
            //do
            //{
            //    sum = sum + (number % 10);
            //    number /= 10;
            //} while (number > 0);

            //Console.WriteLine(sum);

            //int numInput = int.Parse(Console.ReadLine());
            //int finalSum = 0;

            //while (numInput != 0)
            //{
            //    int lastDigit = numInput % 10;
            //    finalSum += lastDigit;
            //    numInput /= 10;

            //}
            //Console.WriteLine(finalSum);

            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            int finalSum = 0;

            for (int value = 0; value < input.ToCharArray().Length; value++)
            {
                finalSum += int.Parse(charArray[value].ToString());
            }
            Console.WriteLine(finalSum);
        }
    }
}

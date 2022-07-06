using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i <items.Length; i++)
            {
                int currentValue = items[i];
                if (currentValue % 2 == 0)
                {
                    sum += currentValue;
                }
            }
            Console.WriteLine(sum);

            //foreach(int item in items)
            //{
            //    if (item % 2 == 0)
            //    {
            //        sum += item;
            //    }
            //}
        }
    }
}

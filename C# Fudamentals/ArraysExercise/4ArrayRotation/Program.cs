using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ',(char)StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotationsCount = int.Parse(Console.ReadLine()); 
            int rotationsCountReduce = rotationsCount % arr.Length;

            for (int rot = 1; rot <= rotationsCountReduce; rot++)
            {
                int firstEl = arr[0];
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    arr[i] = arr[i + 1];
                }

                arr[arr.Length - 1] = firstEl;
            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2CommonElements
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine()
                .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] arr2 = Console.ReadLine()
                .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr2[i] == arr1[j])
                    {
                        Console.Write($"{arr2[i]} ");
                    }
                }
            }
        }
    }
}
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstLength = array.Length;
            
            for (int i = 0; i < firstLength - 1; i++)
            {
                int[] condensed = new int[array.Length - 1];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    condensed[j] = array[j] + array[j + 1];
                }

                array = condensed;
            }

            Console.WriteLine(array[0]);
        }
    }
}

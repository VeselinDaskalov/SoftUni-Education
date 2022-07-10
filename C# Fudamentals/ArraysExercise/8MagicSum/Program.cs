using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ',(char)StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] + input[j] == num)
                    {
                        Console.WriteLine(input[i] + " " + input[j]);
                    }
                }
            }
        }
    }
}

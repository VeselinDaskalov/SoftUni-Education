using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numsCnt = int.Parse(Console.ReadLine());
            int firstSum = 0;
            for(int cnt = 0; cnt < numsCnt; cnt++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSum +=number;
            }
            int secondSum = 0;
            for(int cnt = 0; cnt < numsCnt; cnt++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSum += number;
            }
            if (firstSum == secondSum)
            {
                Console.WriteLine($"Yes, sum = {firstSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(firstSum - secondSum)}");
            }
        }
    }
}

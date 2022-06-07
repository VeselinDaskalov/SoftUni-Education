using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04SumofTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());
            int magical = int.Parse(Console.ReadLine());

            int counter = 0;
            bool yes = true;

            for (int i = num1; i <= finish; i++)
            {
                for (int x = num1; x <= finish; x++)
                {
                    counter++;
                    if (i + x == magical)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {x} = {magical})");
                        yes = false;
                        i = finish;
                    }

                }
            }
            if (yes)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magical}");
            }


            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double account = 0;

            while (input != "NoMoreMoney")
            {   
                double amount = double.Parse(input);
                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                account += amount;
                Console.WriteLine($"Increase: {amount:f2}");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {account:f2}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int maxNumber = int.MinValue;

            while (command != "Stop")
            {
                int n = int.Parse(command);
                if (n > maxNumber)
                {
                    maxNumber = n;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int minNumber = int.MaxValue;

            while (command != "Stop")
            {
                int n = int.Parse(command);
                if (n < minNumber)
                {
                    minNumber = n;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int min = 0; min <= 59; min++)
                {
                    Console.WriteLine($"{hour}:{min}");                    
                }
            }
        }
    }
}

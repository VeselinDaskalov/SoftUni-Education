using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExelantResult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());

            if (a >= 5.50 && a <= 6)
            {
                Console.WriteLine("Excellent!");
            }
           
        }
    }
}

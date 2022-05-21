using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPowersOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1; 

            for (int cnt = 0; cnt <= n; cnt += 2)
            {
                Console.WriteLine(num);
                num *= 2*2;
            }
        }
    }
}

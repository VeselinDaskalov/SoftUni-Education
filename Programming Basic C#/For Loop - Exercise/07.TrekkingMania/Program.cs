using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupNumber = int.Parse(Console.ReadLine());

            int g1 = 0;
            int g2 = 0;
            int g3 = 0;
            int g4 = 0;
            int g5 = 0;

            for (int i = 1; i <= groupNumber; i++)
            {
                int numPeople = int.Parse(Console.ReadLine());

                if (numPeople >= 1 && numPeople <= 5)
                {
                    g1 += numPeople;
                }
                else if(numPeople >= 6 && numPeople <= 12)
                {
                    g2 += numPeople; 
                }
                else if (numPeople >= 13 && numPeople <= 25)
                {
                    g3 += numPeople;
                }
                else if (numPeople >= 26 && numPeople <= 40)
                {
                    g4 += numPeople;
                }
                else if (numPeople >= 41)
                {
                    g5 += numPeople;
                }
                

            }
            double sumPeople = g1 + g2 + g3 + g4 + g5;

            double prg1 = g1 / sumPeople * 100;
            double prg2 = g2 / sumPeople * 100;
            double prg3 = g3 / sumPeople * 100;
            double prg4 = g4 / sumPeople * 100;
            double prg5 = g5 / sumPeople * 100;

            Console.WriteLine($"{prg1:f2}%");
            Console.WriteLine($"{prg2:f2}%");
            Console.WriteLine($"{prg3:f2}%");
            Console.WriteLine($"{prg4:f2}%");
            Console.WriteLine($"{prg5:f2}%");
        }
    }
}

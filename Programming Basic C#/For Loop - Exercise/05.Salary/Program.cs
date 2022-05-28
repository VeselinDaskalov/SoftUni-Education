using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine()); // брой отворени табове
            int salary = int.Parse(Console.ReadLine());

            int penalty = 0;

            for (int i = 1; i <= tabs; i++)
            {
                string site = Console.ReadLine();

                if (site == "Facebook")
                {
                    penalty += 150; 
                }
                else if (site == "Instagram")
                {
                    penalty += 100;
                }
                else if (site == "Reddit")
                {
                    penalty += 50;
                }
                if (penalty >= salary)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (penalty < salary)
            {
                Console.WriteLine(salary - penalty);
            }
        }
    }
}

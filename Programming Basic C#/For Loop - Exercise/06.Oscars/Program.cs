using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double  academyPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());// proverqvashti

            for (int i = 1; i <= n; i++)
            {
                string assessorName = Console.ReadLine();
                double assessorPoints = double.Parse(Console.ReadLine());
                academyPoints += assessorName.Length * assessorPoints / 2;
                if (academyPoints >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {academyPoints:f1}!");
                    break;
                }
            }
            if (academyPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {name} you need {1250.5 - academyPoints:f1} more!");
            }
        }
    }
}

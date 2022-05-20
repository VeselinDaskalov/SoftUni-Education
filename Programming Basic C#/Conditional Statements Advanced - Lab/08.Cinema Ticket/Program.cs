using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();

            if (day == "Monday" || day =="Tuesday"|| day =="Friday")
            {
                Console.WriteLine(12);
            }
            else if (day == "Wednesday"|| day== "Thursday")
            {
                Console.WriteLine(14);
            }    
            else
            {
                Console.WriteLine(16);
            }
        }
    }
}

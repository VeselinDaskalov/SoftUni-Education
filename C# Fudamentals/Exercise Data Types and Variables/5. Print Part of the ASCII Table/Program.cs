using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Print_Part_of_the_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());
             
            for (int i = startIndex; i <= endIndex; i++)
            {
                string asciiChar = ((char)i).ToString();
                Console.Write(asciiChar + " ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int ages = int.Parse(Console.ReadLine());

            //if (ages >= 0 && ages <= 2)
            //{
            //    Console.WriteLine("baby");
            //}
            //else if (ages >= 3 && ages <= 13)
            //{
            //    Console.WriteLine("child");
            //}
            //else if (ages >= 14 && ages <= 19)
            //{
            //    Console.WriteLine("teenager");
            //}
            //else if (ages >= 20 && ages <= 65)
            //{
            //    Console.WriteLine("adult");
            //}
            //else if (ages >= 66)
            //{
            //    Console.WriteLine("elder");
            //}



            //----------------------------------------------------------------------------------------------------


            // Solution with ternary operator


            //-----------------------------------------------------------------------------------------------------



            int age = int.Parse(Console.ReadLine());

            string result = age <= 2 ? "baby" : age > 2 && age <= 13 ? "child" : age > 13 && age <= 19 ? "teenager" : age > 19 && age <= 65
                ? "adult" : "elder";
            Console.WriteLine(result);










        }
    }
}

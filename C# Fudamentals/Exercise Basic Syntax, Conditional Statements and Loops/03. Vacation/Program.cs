using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation1
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupNum = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0.00;

            if (typeGroup == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }

            }
            else if (typeGroup == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }

            }
            else if (typeGroup == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }
            }

            double totalPrice = groupNum * price;
            double discounted = 0.00;

            if (typeGroup == "Regular" && groupNum >= 10 && groupNum <= 20)
            {
                discounted = totalPrice * 0.05;

            }
            else if (typeGroup == "Business" && groupNum >= 100)
            {
                discounted = 10 * price;

            }
            else if (typeGroup == "Students" && groupNum >= 30)
            {
                discounted = totalPrice * 0.15;

            }

            Console.WriteLine($"Total price: {totalPrice - discounted:f2}");

        }
    }
}
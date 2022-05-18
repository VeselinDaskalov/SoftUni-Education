using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCamp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeGrup = Console.ReadLine();
            int numStudents = int.Parse(Console.ReadLine());
            int numNights = int.Parse(Console.ReadLine());


            string typeSport = "";
            double groupPrice = 0.00;         
            

            if (season == "Winter")
            {
                if (typeGrup == "boys" || typeGrup == "girls")
                {                   
                    
                    if (typeGrup == "girls")
                    {
                        groupPrice = numStudents * numNights * 9.60;
                        typeSport = "Gymnastics";
                    }
                    else if(typeGrup == "boys")
                    {
                        groupPrice = numStudents * numNights * 9.60;
                        typeSport = "Judo";
                    }
                }
                else if (typeGrup == "mixed")
                {
                    groupPrice = numStudents * numNights * 10;
                    typeSport = "Ski";
                }

            }
            else if (season == "Spring")
            {
                if (typeGrup == "boys" || typeGrup == "girls")
                {
                    
                    
                    if (typeGrup == "girls")
                    {
                        groupPrice = numStudents * numNights * 7.20;
                        typeSport = "Athletics";
                    }
                    else if (typeGrup == "boys")
                    {
                        groupPrice = numStudents * numNights * 7.20;
                        typeSport = "Tennis";
                    }
                }
                else if (typeGrup == "mixed")
                {
                    groupPrice = numStudents * numNights * 9.50;
                    typeSport = "Cycling";
                }
            }
            else if (season == "Summer")
            {
                if (typeGrup == "boys" || typeGrup == "girls")
                {                 
                   
                    if (typeGrup == "girls")
                    {
                        groupPrice = numStudents * numNights * 15;
                        typeSport = "Volleyball";
                    }
                    else if (typeGrup == "boys")
                    {
                        groupPrice = numStudents * numNights * 15;
                        typeSport = "Football";
                    }
                }
                else if (typeGrup == "mixed")
                {
                    groupPrice = numStudents * numNights * 20;
                    typeSport = "Swimming";
                }
            }
            if(numStudents >= 50)
            {
                groupPrice =groupPrice - groupPrice * 0.50;
            }
            else if (numStudents >= 20 && numStudents <= 50)
            {
                groupPrice = groupPrice - groupPrice * 0.15;
            }
            else if (groupPrice >= 10 && groupPrice <= 20)
            {
                groupPrice = groupPrice - groupPrice * 0.05;
            }
            Console.WriteLine($"{typeSport} {groupPrice:f2} lv.");
        }
    }
}

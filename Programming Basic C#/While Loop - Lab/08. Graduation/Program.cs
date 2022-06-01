using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name =  Console.ReadLine();
            int grade = 1;// the current grade of the student
            double sum = 0;
            int count = 0;

            while (grade <= 12)
            {
                double yearlyGrade = double.Parse(Console.ReadLine());

                if (yearlyGrade < 4)
                {
                    if (count == 1)
                    {
                        break;
                    }
                    count++;
                    continue;
                }

                sum += yearlyGrade;
                grade++;
            }
            double averageGrade = sum / 12;

            if (grade > 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {grade} grade");
            }
            

        }
    }
}

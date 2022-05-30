using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Account Credential
            string userName = Console.ReadLine();
            string password = Console.ReadLine();



            int sumPass = 0;



            string passwordAttempt = Console.ReadLine();

            while(passwordAttempt != password)
            {
                sumPass++;               
                
                if (sumPass == 3)
                {
                    break;
                }
                passwordAttempt = Console.ReadLine();

            }
            if (password == passwordAttempt)
            {
                Console.WriteLine($"Welcome {userName}!");
            }
            else
            {
                Console.WriteLine("Wrong user name or password!");
            }
            


        }
    }
}

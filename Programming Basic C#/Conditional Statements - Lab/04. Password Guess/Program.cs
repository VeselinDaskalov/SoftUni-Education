using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            string pass2 = "s3cr3t!P@ssw0rd";
            if (pass == pass2)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}

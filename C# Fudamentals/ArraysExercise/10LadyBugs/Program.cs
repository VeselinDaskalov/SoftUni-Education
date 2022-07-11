using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Field
            //Array of integers
            //0 -> No ladybug
            //1 -> ladybug

            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladybugsIndexes = Console.ReadLine()
                .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //Initialize the field
            int[] field = new int[fieldSize];
            for (int index = 0; index < fieldSize; index++)
            {
                if (ladybugsIndexes.Contains(index))
                {
                    //If index is present in LadybugsIndexes then there is a ladybug
                    field[index] = 1;
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int initialIndex = int.Parse(cmdArgs[0]);
                string direction = cmdArgs[1];
                int flylength = int.Parse(cmdArgs[2]);

                //First always check if index is valid!!!!
                if (initialIndex < 0 || initialIndex >= field.Length)
                {
                    continue;
                }

                //We have valid index, then we check if there is a ladybug
                // If there isn`t a ladybug
                if (field[initialIndex] == 0)
                {
                    continue;
                }

                //Ladybug starts flying
                //Initial index set to 0, bcos there is no ladybug anymore
                field[initialIndex] = 0;
                int nextIndex = initialIndex;
                while (true)
                {
                    if (direction == "right")
                    {
                        nextIndex += flylength;
                    }
                    else if (direction == "left")
                    {
                        nextIndex -= flylength;
                    }

                    if (nextIndex < 0 || nextIndex >= field.Length)
                    {
                        //Next index is invalid! (outside of the field)
                        break;
                    }

                    if (field[nextIndex] == 0)
                    {
                        //The next index is empty and valid to land
                        //then we land the ladybug there
                        break;
                    }

                }

                if (nextIndex >= 0 && nextIndex < field.Length)
                {
                    //The next calculated is valid!!!
                    //The ladybug land there
                    field[nextIndex] = 1;
                }
            }

            Console.WriteLine(String.Join(" ", field));
        }
    }
}

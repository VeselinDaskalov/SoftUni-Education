using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ',(char)StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            //Worest case -> all integers will br top integers
            int[] topIntegers = new int[arr.Length];
            int topIntegersIndex = 0; // Last index that we appended to topIntrgers array

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                int currentNum = arr[i];
                //By default for me is TopInteger
                bool isTopInteger = true;


                //Nested loop that loops all indexes right to us to end
                for (int j = i + 1; j <= arr.Length - 1; j++)
                {
                    int nextNum = arr[j];

                    if(nextNum >= currentNum)
                    {
                        //Prove that it is not TopInteger
                        isTopInteger = false;
                        break;
                    }
                }
                
                if (isTopInteger)
                {
                    topIntegers[topIntegersIndex] = currentNum;
                    topIntegersIndex++;

                    //Absoloutely same
                    //topIntegers[topIntegersIndex++] = currentNum;
                }
            }

            for (int i = 0; i < topIntegersIndex; i++)
            {
                Console.Write($"{topIntegers[i]} ");
            }

        }
    }
}

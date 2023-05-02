using System;
using System.Collections.Generic;

namespace _1._2._32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int checkCounter = 0;
            int minNumber = n;
            int maxNumber = 1;

            for (int i = 1; i <= n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input == i && maxNumber < input)
                {
                    maxNumber = input;
                    checkCounter++;
                }

                if (input == i && minNumber > input)
                {
                    minNumber = input;
                    checkCounter++;
                }
            }

            if (checkCounter > 2)
            {
                Console.WriteLine(minNumber + " " + maxNumber);
            }
            else
            {
                Console.WriteLine("0 0");
            }

        }
    }
}

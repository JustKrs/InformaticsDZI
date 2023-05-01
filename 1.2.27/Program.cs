using System;
using System.Collections.Generic;

namespace _1._2._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                int input = int.Parse(Console.ReadLine());
                list.Add(input);
            }
            
            int counter = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 2)
                {
                    Console.WriteLine("No");
                    return;
                }
                else if (list[i] == 6)
                {
                    counter++;
                }
            }
            Console.WriteLine(('*', counter));
        }
    }
}

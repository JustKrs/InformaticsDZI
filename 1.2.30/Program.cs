using System;
using System.Collections.Generic;

namespace _1._2._30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                list.Add(input);
            }

            list.Sort();

            for (int i = 0; i < 2; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}

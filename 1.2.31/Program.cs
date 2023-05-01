using System;
using System.Collections.Generic;
using System.Linq;

/*
 input:
6
5
2
2
6
3
4
3
8
2
7
5
6
*/

namespace _1._2._31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

            for (int i = 0; i < n; i++)
            {
                int length = int.Parse(Console.ReadLine());
                int maxHeight = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(length))
                {
                    dict.Add(length, new List<int>() { maxHeight });
                }
                else
                {
                    dict[length].Add(maxHeight);
                }
            }

            foreach (var item in dict.OrderBy(x => x.Key).ThenBy(x => x.Value))
            {
                Console.WriteLine($"{item.Key} - {String.Join(", ", item.Value)}");
                return;
            }
        }
    }
}

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
            int n, d, m, mind, minm;
            n = int.Parse(Console.ReadLine()); // брой на наклоните
            m = int.Parse(Console.ReadLine()); // максимален наклон
            d = int.Parse(Console.ReadLine()); // дължината на пътеките

            minm = m;
            mind = d;

            for (int i = 2; i <= n; i++)
            {
                m = int.Parse(Console.ReadLine());
                d = int.Parse(Console.ReadLine());

                if (m < minm || m == minm && d < mind)
                {
                    minm = m;
                    mind = d;
                }
            }

            Console.WriteLine(minm + " " + mind);
            return;
        }
    }
}

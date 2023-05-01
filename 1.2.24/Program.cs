using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Metadata;

namespace _1._2._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h, m, s, moment;

            h = int.Parse(Console.ReadLine());
            if (h < 8)
            {
                h += 24;
            }
            m = int.Parse(Console.ReadLine());

            s = int.Parse(Console.ReadLine());

            moment = (3600 * h + 60 * m + s - 8 * 3600) % 108;

            if (moment < 60)
            {
                Console.WriteLine("premini");
            }
            else if (moment < 64)
            {
                Console.WriteLine("izchakai");
            }
            else if (moment < 104)
            {
                Console.WriteLine("spri");
            }
            else
            {
                Console.WriteLine("izchakai");
            }

            return;
        }
    }
}

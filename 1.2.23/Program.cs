using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _1._2._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    string input = Console.ReadLine();
            //    List<int> list = new List<int>();

            //    int number = int.Parse(input);

            //    for (int i = 0; i < input.Length; i++)
            //    {
            //        int currentDigit = number % 10;
            //        list.Add(currentDigit);
            //        number = number / 10;
            //    }
            //    list.Reverse();

            //    int evenNumbersCount = 0;
            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        if (list[i] % 2 == 0)
            //        {
            //            evenNumbersCount++;
            //        }
            //    }

            //    int absolute1 = 0;
            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            if (absolute1 == 0)
            //            {
            //                absolute1 = list[i];
            //            }
            //            else
            //            {
            //                absolute1 = Math.Abs(absolute1 - list[i]);
            //            }
            //        }
            //    }

            //    int absolute2 = 0;
            //    for (int i = list.Count - 1; i >= 0; i--)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            if (absolute2 == 0)
            //            {
            //                absolute2 = list[i];
            //            }
            //            else
            //            {
            //                absolute2 = Math.Abs(absolute2 - list[i]);
            //            }
            //        }
            //    }

            //    Console.WriteLine(evenNumbersCount + "" + absolute1 + "" + absolute2);

            string N = "";
            int first, diff;
            N = Console.ReadLine();
            first = (N[0] - '0') % 2 + (N[1] - '0') % 2 + (N[2] - '0') % 2 + (N[3] - '0') % 2;
            first = first + (N[4] - '0') % 2 + (N[5] - '0') % 2;
            diff = (N[0] - '0') * 100 + (N[2] - '0') * 10 + (N[4] - '0');
            diff = diff + ((N[4] - '0') * 100 + (N[2] - '0') * 10 + (N[0] - '0'));

            if (diff < 0)
            {
                diff = diff * -1;
            }
            Console.Write(first);

            if (diff < 10)
            {
                Console.Write("00");
            }

            if (diff >= 10 & diff < 100)
            {
                Console.WriteLine("0");
            }

            Console.WriteLine(diff);

            return;
        }
    }
}

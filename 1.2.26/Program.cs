using System;
using System.Collections.Generic;

namespace _1._2._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();
            list.Add(a);
            list.Add(b);
            list.Add(c);

            list.Sort();
            list.Reverse();

            Console.WriteLine(String.Join(" ", list));
        }
    }
}

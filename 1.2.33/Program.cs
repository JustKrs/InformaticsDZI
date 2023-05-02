using System;

namespace _1._2._33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // числа на часовника
            int d = int.Parse(Console.ReadLine()); // диапазон на прескачане
            int k = int.Parse(Console.ReadLine()); // брой скокове

            int sum = 1;
            int pos = 1;


            for (int i = 1; i <= k; i++)
            {
                pos = (pos + d) % n;
                sum += (pos == 0 ? n : pos);
            }

            Console.WriteLine(sum);


        }
    }
}

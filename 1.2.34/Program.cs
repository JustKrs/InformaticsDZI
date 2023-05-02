using System;

namespace _1._2._34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int counter = 0;
            int sum = 0;
            for (int i = n; i <= m; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    counter++;
                }
            }

            Console.WriteLine(sum / counter);

            //if (m % 2 == 1) m++;
            //if (n % 2 == 1) n--;

            //Console.WriteLine((n + m) / 2);
        }
    }
}

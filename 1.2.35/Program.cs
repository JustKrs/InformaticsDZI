using System;

namespace _1._2._35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long m = 0;
            long tmp;

            long n = long.Parse(Console.ReadLine());
            tmp = n;

            while (n > 0)
            {
                m = m * 10 + n % 10;
                n = n / 10;
            }

            if (m == tmp)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}

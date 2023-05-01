using System;

namespace _1._2._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            string result = "";

            if (x > 0 && y > 0)
            {
                result = "I";
            }
            else if (x < 0 && y > 0)
            {
                result = "II";
            }
            else if (x < 0 && y < 0)
            {
                result = "III";
            }
            else if (x > 0 && y < 0)
            {
                result = "IV";
            }
            else if (x == 0 && y != 0)
            {
                result = "V";
            }
            else if (x != 0 && y == 0)
            {
                result = "H";
            }
            else if (x == 0 && y == 0)
            {
                result = "O";
            }

            Console.WriteLine(result);
        }
    }
}

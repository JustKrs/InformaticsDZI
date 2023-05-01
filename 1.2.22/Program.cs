using System;

namespace _1._2._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade = int.Parse(Console.ReadLine());

            if (grade == 2)
            {
                Console.WriteLine("Слаб");
            }
            else if (grade == 3)
            {
                Console.WriteLine("Среден");
            }
            else if (grade == 4)
            {
                Console.WriteLine("Добър");
            }
            else if (grade == 5)
            {
                Console.WriteLine("Много добър");
            }
            else if (grade == 6)
            {
                Console.WriteLine("Отличен");
            }
            else
            {
                Console.WriteLine("Невалидна оценка");
            }

        }
    }
}

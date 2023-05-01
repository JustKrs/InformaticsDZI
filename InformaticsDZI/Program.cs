using System;

namespace InformaticsDZI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int hours = int.Parse(input.Substring(0, 2));
            int minutes = int.Parse(input.Substring(3, 2));
            int seconds = int.Parse(input.Substring(6, 2));

            string result = AddSecond(hours, minutes, seconds);

            Console.WriteLine(result);
        }

        public static string AddSecond(int hours, int minutes, int seconds)
        {
            if (seconds < 59 && minutes < 59 && hours < 24)
            {
                seconds++;
            }
            else if (seconds == 59 && minutes < 59 && hours < 24)
            {
                seconds = 0;
                minutes++;
            }
            else if (seconds == 59 && minutes == 59 && hours < 23)
            {
                seconds = 0;
                minutes = 0;
                hours++;
            }
            else if (seconds == 59 && minutes == 59 && hours == 23)
            {
                seconds = 0;
                minutes = 0;
                hours = 0;
            }
            else
            {
                return "Некоректни данни";
            }

            return $"{hours.ToString("00")}:{minutes.ToString("00")}:{seconds.ToString("00")}";
        }
    }
}

//Угол а задан в градусах, минутах и секундах. Найти его величину в радианах. 

using System.Drawing;

namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degree, minute, second, sum_second;

            Console.Write("\nВведите градусы: ");
            degree = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nВведите минуты: ");
            minute = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nВведите секунды: ");
            second = Convert.ToInt32(Console.ReadLine());

            sum_second = degree * 3600 + minute * 60 + second;
            int degreeFromSec, minuteFromSec, secondFromSec;

            degreeFromSec = sum_second / 3600;
            minuteFromSec = sum_second % 3600 / 60;
            secondFromSec = sum_second % 3600 % 60;

            double resultDegrees = degreeFromSec % 360 + minuteFromSec * 1.0 / 60 + secondFromSec * 1.0 / 3600;
            double resultRadians = resultDegrees * Math.PI / 180;

            Console.WriteLine("Итоговый угол в градусах: {0}", resultDegrees);
            Console.WriteLine("Итоговый угол в радианах: {0}", resultRadians);

        }
    }
}

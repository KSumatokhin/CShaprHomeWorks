// Длина отрезка задана в дюймах (1 дюйм = 2,54 см). Перевести значение длины в метрическую систему,
// то есть выразить ее в метрах, сантиметрах и миллиметрах. Например, 21 дюйм = 0 м 53 см 3,4 мм

namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double inchInMm = 25.4;

            Console.Write("\nВведите длину, дюйм: ");
            double lengthInch = Convert.ToDouble(Console.ReadLine());

            double lengthMm = inchInMm * lengthInch;
                
            int meter = (int)lengthMm / 1000;
            int centimeter = (int)lengthMm % 1000 / 10;
            double milimeter = lengthMm % 1000 % 10;

            Console.WriteLine("{0} дюйм = {1} м {2} см {3:F1} мм", lengthInch, meter, centimeter, milimeter);

        }
    }
}

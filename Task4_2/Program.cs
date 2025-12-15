// Вводится натуральное число n. Найти 1 + 1/2 + 1/3 + … + 1/n

namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nВведите положительное натуральное число: ");
            int number;
            bool success = int.TryParse(Console.ReadLine(), out number);
            double harmonicNumber = 0;

            if (success && number >= 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    harmonicNumber += 1.0 / i;
                }
                Console.WriteLine("Частичная сумма гармонического ряда до числа {0} - {1:F5}", number, harmonicNumber);
            }
            else
            {
                Console.WriteLine("Введенное значение должно быть положительным числом");
            }
        }
    }
}
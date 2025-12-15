// Вводится натуральное число n. Найти n! Например, 6! = 1 * 2 * 3 * 4 * 5 * 6.

using System;

namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nВведите положительное натуральное число: ");
            int number;
            bool success = int.TryParse(Console.ReadLine(), out number);
            long factorial = 1;

            if (success && number >= 0)
            {
                for (int i = 2; i <= number; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine("Факториал числа {0} - {1}", number, factorial);
            }
            else
            {
                Console.WriteLine("Введенное значение должно быть положительным числом");
            }
        }
    }
}
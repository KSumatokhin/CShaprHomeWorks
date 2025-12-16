

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Наберите номер задачи: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Task4_1();
                    break;
                case "2":
                    Task4_2();
                    break;
                case "3":
                    Task4_3();
                    break;
                case "4":
                    Task4_4();
                    break;
                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }
        }

        // Вводится натуральное число n. Найти n! Например, 6! = 1 * 2 * 3 * 4 * 5 * 6.
        static void Task4_1()
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

        // Вводится натуральное число n. Найти 1 + 1/2 + 1/3 + … + 1/n
        static void Task4_2()
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

        // Вводятся целые числа a>0, b>0. Найти a^b. Не использовать класс Math
        static void Task4_3()
        {
            Console.Write("Введите a (>0): ");
            if (!int.TryParse(Console.ReadLine(), out int a) || a <= 0)
            {
                Console.WriteLine("Ошибка: должно быть целое число > 0");
                return;
            }
            Console.Write("Введите b (>0): ");
            if (!int.TryParse(Console.ReadLine(), out int b) || b <= 0)
            {
                Console.WriteLine("Ошибка: должно быть целое число > 0");
                return;
            }

            long result = 1;

            for (int i = 1; i <= b; i++)
            {
                result *= a;
            }

            Console.WriteLine("При возведении {0} в степень {1} получится - {2}", a, b, result);

        }

        // Вводятся целые числа a>0, b<0. Найти a^b. Не использовать класс Math
        static void Task4_4()
        {
            Console.Write("Введите a (>0): ");
            if (!int.TryParse(Console.ReadLine(), out int a) || a <= 0)
            {
                Console.WriteLine("Ошибка: должно быть целое число > 0");
                return;
            }
            Console.Write("Введите b (<0): ");
            if (!int.TryParse(Console.ReadLine(), out int b) || b >= 0)
            {
                Console.WriteLine("Ошибка: должно быть целое число < 0");
                return;
            }

            b = b * (-1);
            double result = 1;

            for (int i = 1; i <= b; i++)
            {
                result *= a;
            }

            result = 1.0 / result;

            Console.WriteLine("При возведении {0} в отрицательную степень {1} получится - {2:F5}", a, b, result);

        }

    }
}
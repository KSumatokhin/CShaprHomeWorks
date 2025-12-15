// Вводится натуральное число n. Найти n! Например, 6! = 1 * 2 * 3 * 4 * 5 * 6.

namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nВводите натуральное число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int n_factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                n_factorial *= i;
            }

            Console.WriteLine("Натуральный логарифм числа {0} - {1}", num, n_factorial);
        }
    }
}
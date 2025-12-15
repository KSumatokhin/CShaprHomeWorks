//Вводится четырехзначное число. Поменять местами 2-ую и 4-ую цифру.

namespace Task2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nВведите четрырехзначное число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Разбираем число по порядкам
            int n1, n2, n3, n4, num2;
            n1 = num / 1000; // Первое число
            n2 = (num - n1 * 1000) / 100; // Второе число
            n3 = (num - n1 * 1000 - n2 * 100) / 10; // Третье число
            n4 = num % 10; // Четвертое число

            //Меняем местами
            num2 = n1 * 1000 + n4 * 100 + n3 * 10 + n2;

            Console.Write("\nПоменяли местами 2-ую и 4-ую цифру: {0}", num2); 

        }
    }
}

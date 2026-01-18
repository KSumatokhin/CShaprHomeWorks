using System.Threading.Channels;

namespace Guess_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                PlayGame();

                Console.Write("\nХотите сыграть ещё раз? (Yes/No) <No>: ");
                string answer = Console.ReadLine()?.Trim().ToLower();

                playAgain = answer == "yes" || answer == "y" || answer == "да" || answer == "д";
            }

            Console.WriteLine("\nСпасибо за игру! До свидания!");
            Console.ReadKey();
        }

        static void PlayGame()
        {
            Console.Clear();
            Console.WriteLine("Игра \"Угадай число\"");
            Console.WriteLine("Компьютер загадал число от 1 до 1000.");
            
            Random random = new Random();
            int secret = random.Next(1, 1001);
            int attempts = 0;
            bool guessed = false;

            while (!guessed)
            {
                attempts++;
                Console.WriteLine($"Попытка No.{attempts}");
                Console.Write("Введите число от 1 до 1000: ");

                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Ошибка: введите целое число! Попытка не засчитана.");
                    attempts--;
                    continue;
                }

                if (number < 1 || number > 1000)
                {
                    Console.WriteLine("Ошибка: число должно быть от 1 до 1000! Попытка не засчитана.");
                    attempts--;
                    continue;
                }

                if (number == secret)
                {
                    guessed = true;
                    Console.WriteLine($"\nПоздравляем! Вы угадали число {secret} за {attempts} попыток!");
                }
                else if (number < secret)
                {
                    Console.WriteLine("Загаданное число БОЛЬШЕ.");
                }
                else
                {
                    Console.WriteLine("Загаданное число МЕНЬШЕ.");
                }
            }
        }
    }
}

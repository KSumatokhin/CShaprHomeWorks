namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string sentence = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(sentence))
            {
                Console.WriteLine("Вы ввели пустую строку.");
                return;
            }
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                Console.WriteLine("Не найдено ни одного слова.");
                return;
                // Разделяем строку на слова по пробелам

            }

            // Находим самое длинное слово
            string longestWord = words[0];

            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > longestWord.Length)
                {
                    longestWord = words[i];
                }
            }

            Console.WriteLine($"Самое длинное слово: \"{longestWord}\" (длина: {longestWord.Length})");
        }
    }
}

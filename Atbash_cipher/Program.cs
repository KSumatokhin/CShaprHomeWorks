using System.Text;
using System.Threading.Channels;

namespace Atbash_cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string asciiCharsEn = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string asciiCharsRu = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string[] asciiChars = { asciiCharsEn, asciiCharsRu };

            Console.Write("Введите фразу для кодировки <Выход>: ");
            string phrase = Console.ReadLine() ?? "";

            if (phrase == "") return;

            StringBuilder upperCaseTest = new StringBuilder();

            foreach (char c in phrase)
            {
                char upperCode = Char.IsUpper(c) ? '1' : '0';
                upperCaseTest.Append(upperCode);
            }

            phrase = phrase.ToUpper();

            StringBuilder result = new StringBuilder();

            foreach (char letter in phrase)
            {
                bool isAdded = false;
                foreach (string chars in asciiChars)
                {
                    int numberChars = chars.Count();
                    if (chars.Contains(letter))
                    {
                        int letterNumber = chars.IndexOf(letter);
                        int cipherNumber = numberChars - letterNumber;
                        result.Append(chars.Substring(cipherNumber - 1, 1));
                        isAdded = true;
                    }
                }
                if (!isAdded)
                    result.Append(letter);
            }

            for (int i = 0; i < result.Length; i++)
            {
                if (upperCaseTest[i] == '0')
                    result.Replace(result[i], Char.ToLower(result[i]), i, 1);
            }

            Console.WriteLine(result);
        }
    }
}

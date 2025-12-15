//Застройщик построил n домов. Вывести фразу «Мы построили n домов», обеспечив
//правильное согласование числа со словом «дом», например:
//20 — «Мы построили 20 домов»,
//32 — «Мы построили 32 дома»,
//41 — «Мы построили 41 дом».

namespace Task3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nСколько домов построил застройщик: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 100 >= 11 && num % 100 < 15)
            {
                Console.WriteLine("Мы построили {0} домов", num);
            }
            else
            {
                switch (num % 10)
                {
                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine("Мы построили {0} дома", num);
                        break;
                    case 1:
                        Console.WriteLine("Мы построили {0} дом", num);
                        break;
                    default: // 0,5-9
                        Console.WriteLine("Мы построили {0} домов", num);
                        break;
                }
            }
        }
    }
}

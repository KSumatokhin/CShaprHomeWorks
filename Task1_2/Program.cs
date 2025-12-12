namespace Task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, a1, b, b1, c, c1;
            Console.Write("\nВведите первое число: a=");
            a = b1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nВведите второе число: b=");
            b = c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nВведите третье число: c=");
            c = a1 = Convert.ToInt32(Console.ReadLine());

            a = a1; b = b1; c = c1;

            Console.Write("\nНо мы все поменяли, и теперь: a={0}, b={1}, c={2}", a, b, c);


        }
    }
}

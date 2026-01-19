namespace Task14
{
    internal class Program
    {
        //delegate void MyDelegate();
        //delegate void MyDelegate(string a);
        //delegate int MyDelegate(int a, int b);

        static void Main(string[] args)
        {
            //MyDelegate myDelegate = new MyDelegate(Method1);
            //MyDelegate myDelegate = Method1;
            //myDelegate += Method2;
            //myDelegate -= Method1;
            //myDelegate -= Method2;

            //if (myDelegate != null)
            //    myDelegate();

            //myDelegate?.Invoke();

            Action<string> action = Method3;

            //MyDelegate myDelegate = Method5;

            action.Invoke("Hello");

            Console.ReadKey();
        }

        static void Method1()
        {
            Console.WriteLine("Method1");
        }

        static void Method2()
        {
            Console.WriteLine("Method2");
        }

        static void Method3(string message)
        {
            Console.WriteLine("Method3");
            Console.WriteLine(message);
        }

        static string Method4(string message)
        {
            Console.WriteLine("Method4");
            Console.WriteLine(message);
            return message;
        }

        static int Method5(int a, int b)
        {
            Console.WriteLine("Method5");
            return a + b;
        }

        static int Method6(int a, int b)
        {
            Console.WriteLine("Method6");
            return a * b;
        }

        static string Method7(string message, int value)
        {
            Console.WriteLine("Method7");
            Console.WriteLine(message + value);
            return message + value;
        }

        static string Method8(int value, string message)
        {
            Console.WriteLine("Method8");
            Console.WriteLine(message + value);
            return message + value;
        }

        static void Method9(string message, int value)
        {
            Console.WriteLine("Method9");
            Console.WriteLine(message + value);
        }

        static bool Method10(int value)
        {
            Console.WriteLine("Method10");
            return value % 2 == 0;
        }
    }
}


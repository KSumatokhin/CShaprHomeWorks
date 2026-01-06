namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(null, "fg",158, 56);

            Console.WriteLine(book1);
            Console.WriteLine(book1.GetInfo());
        }
    }
}

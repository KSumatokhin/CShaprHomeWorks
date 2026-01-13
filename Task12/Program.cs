namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product<int, decimal>[] products = new Product<int, decimal>[]
                {
                    new Product<int, decimal>("НеМолоко", 100m, 1),
                    new Product<int, decimal>("НеМолоко", 200m, 2),
                    new Product<int, decimal>("Хлеб}", 50m, 3)
                };

            Product<int, decimal> product = FindProduct<int, decimal>(products, 5);

            Console.WriteLine(product?.ToString() ?? "Не найдено");

        }

        static Product<T, U> FindProduct<T, U>(Product<T, U>[] products, T id)
        {
            foreach (Product<T, U> product in products)
            {
                if (product.Id.Equals(id))
                    return product;
            }
            return null;
        }

    }

    class Product<T, U>
    {
        public string Name { get; set; }
        public U Price { get; set; }
        public T Id { get; set; }

        public Product(string name, U price, T id)
        {
            Name = name;
            Price = price;
            Id = id;

        }

        public override string ToString()
        {
            return $"Id: {Id} ({typeof(T).Name}), Name: {Name}, Price: {Price} ({typeof(U).Name}),";
        }

    }


}

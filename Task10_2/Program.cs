namespace Task10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Создание объектов
            Building simpleBuilding = new Building("ул. Ленина, 1", 150.5, 1990);
            MultiBuilding multiBuilding = new MultiBuilding("ул. Пушкина, 10", 1200.75, 2010, 12, true);

            Console.WriteLine("=== Простое здание ===");
            simpleBuilding.DisplayInfo();

            Console.WriteLine("\n=== Многоэтажное здание ===");
            multiBuilding.DisplayInfo();

            // 2. Upcasting (приведение к базовому типу)
            Building upcasted = multiBuilding; // неявное приведение
            Console.WriteLine("\n=== Upcasting ===");
            Console.WriteLine($"Тип объекта: {upcasted.GetType().Name}");
            upcasted.DisplayInfo(); // вызовется переопределённый метод!

            // 3. Downcasting (обратное приведение с проверкой)
            Console.WriteLine("\n=== Downcasting ===");
            if (upcasted is MultiBuilding)
            {
                MultiBuilding downcasted = (MultiBuilding)upcasted; // явное приведение
                                                                    // MultiBuilding downcasted = upcasted as MultiBuilding; // альтернатива
                Console.WriteLine("Приведение успешно!");
                Console.WriteLine($"Площадь на этаж: {downcasted.AreaPerFloor:F2} м²");

                // 4. Вызов уникального метода производного класса
                Console.WriteLine($"Уникальное свойство: {downcasted.AreaPerFloor:F2} м² на этаж");
            }

            // 5. Попытка некорректного downcasting
            Console.WriteLine("\n=== Некорректный downcasting ===");
            try
            {
                MultiBuilding wrongCast = (MultiBuilding)simpleBuilding; // InvalidCastException
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Ошибка приведения: объект не является MultiBuilding");
            }

            // 6. Безопасное приведение с помощью as
            MultiBuilding safeCast = simpleBuilding as MultiBuilding;
            if (safeCast == null)
            {
                Console.WriteLine("Безопасное приведение: объект не является MultiBuilding");
            }
        }
    }
}

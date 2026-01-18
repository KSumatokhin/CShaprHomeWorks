namespace Battle_monster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }

    public class Character
    {
        public string Name { get; }
        public int Health { get; set; }
        public int Damage { get; protected set; }
        public bool IsAlive => Health > 0;

        public Character(string name, int health, int damage)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Health = health > 0 ? health : throw new ArgumentException("Здоровье должно быть положительным");
            Damage = damage >= 0 ? damage : throw new ArgumentException("Урон не может быть отрицательным");
        }

        public virtual void Attack(Character target)
        {
            if (!IsAlive || !target.IsAlive)
                throw new InvalidOperationException("Персонаж не может атаковать!");

            target.Health -= Damage;
            Console.WriteLine($"{Name} наносит {Damage} урона {target.Name}!");
        }
    }

    public class Player : Character
    {
        private int _healthPotions = 3;
        public int HealthPotions => _healthPotions;

        public Player(string name)
            : base(name, health: 10, damage: 5)
        {
        }

        public void UseHealthPotion()
        {
            if (_healthPotions <= 0)
                throw new InvalidOperationException("Зелья здоровья закончились!");

            Health += 10;
            _healthPotions--;
            Console.WriteLine($"{Name} использует зелье здоровья! +10 HP. Осталось зелий: {_healthPotions}");
        }
    }

    public class Monster : Character
    {
        private static readonly Random _random = new Random();
        public Monster()
            : base("Злобный Гоблин", health: 20, damage: 0)
        {
        }

        public override void Attack(Character target)
        {
            Damage = _random.Next(1, 11);
            base.Attack(target);
        }
    }

    public class Game
    {
        private Player _player;
        private Monster _monster;

        public void Start()
        {
            Console.WriteLine("=== Игра 'Битва с монстром' ===");
            Console.Write("Введите имя вашего персонажа: ");
            string? input = Console.ReadLine();
            string playerName = string.IsNullOrEmpty(input) ? "Герой" : input.Trim();

            _player = new Player(playerName);
            _monster = new Monster();

            Console.WriteLine($"\nБитва начинается! {_player.Name} против {_monster.Name}!");

            while (_player.IsAlive && _monster.IsAlive)
            {
                PlayerTurn();
                if (!_monster.IsAlive) break;

                MonsterTurn();
                ShowStatus();
            }

            ShowResult();
        }

        private void PlayerTurn()
        {
            Console.WriteLine("=== Ваш ход ===");
            Console.WriteLine("1 - Атаковать / 2 - Использовать зелье здоровья");
            Console.Write("Выберите действие: ");

            int.TryParse(Console.ReadLine(), out int number);

            switch (number)
            {
                case 1:
                    _player.Attack(_monster);
                    break;
                case 2:
                    try
                    {
                        _player.UseHealthPotion();
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                        PlayerTurn();
                    }
                    break;
                default:
                    Console.WriteLine("Неверный выбор!");
                    PlayerTurn();
                    break;
            }
        }

        private void MonsterTurn()
        {
            Console.WriteLine($"Ход {_monster.Name}...");
            _monster.Attack(_player);
        }

        private void ShowStatus()
        {
            Console.WriteLine($"Текущее состояние:");
            Console.WriteLine($"{_player.Name}: {_player.Health} HP (Зелья: {_player.HealthPotions})");
            Console.WriteLine($"{_monster.Name}: {_monster.Health} HP");
        }

        private void ShowResult()
        {
            Console.WriteLine("\n=== Битва окончена ===");
            if (_player.IsAlive)
                Console.WriteLine($"Поздравляем! {_player.Name} победил!");
            else
                Console.WriteLine($"Поражение! {_monster.Name} победил!");
        }
    }

}

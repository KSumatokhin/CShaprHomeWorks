using System;
using System.Collections.Generic;
using System.Text;

namespace Task9
{
    internal partial class BankAccount
    {
        private static int _totalAccounts = 0;
        private static readonly Random _random = new Random();

        public int AccountNumber { get; }
        public decimal Balance { get; private set; }


        public BankAccount()
        {
            AccountNumber = _random.Next(1000, 10000);
            Balance = 0;
            _totalAccounts++;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма пополнения должна быть положительной", nameof(amount));
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма снятия должна быть положительной", nameof(amount));
            if (amount > Balance)
                throw new InvalidOperationException($"Недостаточно средств. Баланс: {Balance}, запрошено: {amount}");
            Balance -= amount;
        }

        public void ShowTotalAccounts() => Console.WriteLine($"Всего создано счетов: {_totalAccounts}");
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Task9
{
    internal partial class Book
    {
        private readonly string _title;
        private readonly string _author;
        private int _year;
        private int _pages;

        public int Year
        {
            get => _year;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Год должен быть положительным");
                _year = value;
            }
        }

        public int Pages
        {
            get => _pages;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Количество страниц должно быть положительным");
                _pages = value;
            }
        }

        public string Title => _title;
        public string Author => _author;

        public Book(string title, string author, int year, int pages)
        {
            _title = title ?? throw new ArgumentNullException(nameof(title));
            _author = author ?? throw new ArgumentNullException(nameof(author));
            Year = year;
            Pages = pages;
        }

        public string GetInfo() => $"{_title}, {_author}, {Year}, {Pages} стр.";
    }
}

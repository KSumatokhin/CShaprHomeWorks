using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Task10_2
{
    internal partial class Building
    {
        private string _address;
        protected double _area;
        private int _yearBuilt;

        public Building(string address, double area, int yearBuilt)
        {
            _address = address ?? throw new ArgumentNullException(nameof(address));

            if (area <= 0)
                throw new ArgumentException("Площадь должна быть положительной", nameof(area));
            _area = area;

            if (yearBuilt > DateTime.Now.Year)
                throw new ArgumentException("Год постройки не может быть в будущем", nameof(yearBuilt));
            _yearBuilt = yearBuilt;
        }

        public int BuildingAge => DateTime.Now.Year - _yearBuilt;


        public virtual double CalculateTax()
        {
            return _area * 1000;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Адрес: {_address}");
            Console.WriteLine($"Площадь: {_area:F2} кв.м");
            Console.WriteLine($"Год постройки: {_yearBuilt} (возраст: {BuildingAge} лет)");
            Console.WriteLine($"Налог: {CalculateTax():C}");
        }
    }

}

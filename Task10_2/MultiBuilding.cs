using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Task10_2
{
    internal sealed partial class MultiBuilding : Building
    {
        private int _floors;
        private bool _hasElevator;

        public MultiBuilding(string address, double area, int yearBuilt, int floors, bool hasElevator)
            : base(address, area, yearBuilt)
        {
            if (floors <= 0)
                throw new ArgumentException("Количество этажей должно быть положительным", nameof(floors));
            _floors = floors;
            _hasElevator = hasElevator;
        }

        public double AreaPerFloor => _area / _floors;

        public override double CalculateTax()
        {
            double baseTax = base.CalculateTax();
            double floorCoefficient = (1 + (_floors - 1) * 0.05);
            double elevatorFee = _hasElevator ? 5000.0 : 0.0;

            return baseTax * floorCoefficient + elevatorFee;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Количество этажей: {_floors}");
            Console.WriteLine($"Наличие лифта: {(_hasElevator ? "есть" : "нет")}");
            Console.WriteLine($"Средняя площадь на этаж: {AreaPerFloor:F2} кв.м");
            Console.WriteLine($"Налог (с учётом этажей и лифта): {CalculateTax():C}");
        }
    }
}

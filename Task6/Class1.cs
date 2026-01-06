using System;
using System.Collections.Generic;
using System.Text;

namespace Task6
{
    class Cat
    {
        public const int countFeet = 4;

        public readonly bool wool = true;

        public string Name { get; set; }
        public string Color { get; set; }
        int age;

        public int Age
        {
            set
            {
                if (value > 0)
                    age = value;
            }
            get {return age; }
        }

        public Cat(string name,  string color, int age, bool wool)
        {
            Name = name;
            Color = color;
            Age = age;
            this.wool = wool;
        }
    }
}

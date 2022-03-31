using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_zadanie
{
    class Meat:Product
    {
        public Meat(string name, double weight) : base(name)
        {
            Weight = weight;
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public override void Print(string prefix)
        {
            Console.WriteLine($"{prefix}{Name} ({Weight} kg)");
        }
    }
}

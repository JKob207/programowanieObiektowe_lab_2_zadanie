using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_zadanie
{
    class Fruit : Product
    {
        public Fruit(string name, int count) : base(name)
        {
            Count = count;
        }

        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public override void Print(string prefix)
        {
            Console.WriteLine($"{prefix}{Name} ({Count} fruits)");
        }
    }
}

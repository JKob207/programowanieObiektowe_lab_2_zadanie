using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_zadanie
{
    abstract class Product:IThing
    {
        public Product(string name)
        {
            this.name = name;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = Name; }
        }

        public abstract void Print(string prefix);
    }
}

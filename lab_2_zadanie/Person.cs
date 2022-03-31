using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_zadanie
{
    abstract class Person:IThing
    {
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = Name; }
        }
        public int Age
        {
            get { return age; }
            set { age = Age; }
        }

        public abstract void Print(string prefix);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_zadanie
{
    class Shop:IThing
    {
        public Shop(string name, Person[] people, Product[] products)
        {
            Name = name;
            this.people = people;
            this.products = products;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string name;
        private Person[] people;
        private Product[] products;

        public void Print()
        {
            Console.WriteLine($"Shop: {Name}");
            if(people.Length > 0)
            {
                Console.WriteLine("-- People: --");
                foreach(Person p in people)
                {
                    p.Print("\t");
                }
            }
            if(products.Length > 0)
            {
                Console.WriteLine("-- Products: --");
                foreach (Product p in products)
                {
                    p.Print("\t");
                }
            }
        }
    }
}

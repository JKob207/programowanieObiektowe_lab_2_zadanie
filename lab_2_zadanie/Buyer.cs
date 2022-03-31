using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_zadanie
{
    class Buyer:Person
    {
        public Buyer(string name, int age) : base(name, age){}

        protected List<Product> tasks = new List<Product>();

        public void AddProduct(Product product)
        {
            tasks.Add(product);
        }

        public void RemoveProduct(int index)
        {
            tasks.RemoveAt(index);
        }

        public override void Print(string prefix)
        {
            Console.WriteLine($"{prefix}Buyer: {Name} {Age} (y.o.)");
            if(tasks.Count > 0)
            {
                Console.WriteLine($"{prefix}-- Products: --");
                foreach(var t in tasks)
                {
                    t.Print($"{prefix}\t");
                }
            }
        }
    }
}

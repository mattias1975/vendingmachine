using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    abstract class Product
    {
        static int countId = 1;

        public int Id { get; private set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Id = countId++;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Id + ": " + Name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine;

namespace VendingMashine
{
    class Soda : Product
    {
        protected string color;
        protected double size;
        public Soda(string name, int price, string color, int size) : base(name, price)
        {
            this.color = color;

            this.size = size;

        }
    }
}







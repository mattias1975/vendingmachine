﻿using VendingMachine;

namespace VendingMashine
{
    class choclate: Product
    {
        protected string color;
        protected double size;
        public choclate(string name, int price, string color, int size) : base(name, price)
        {
            this.color = color;
            // writing to have something to save
            this.size = size;
          

        }


    }
}



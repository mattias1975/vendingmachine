﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMashine
{


    class Soda
    {
        protected string name { get; set; }
         protected string color { get; set; }
        protected double size { get; set; }
        public Soda(string name, string color, int size)
        {
            this.name = name;

            this.color = color;

            this.size = size;
            return ;
        }
    }
}









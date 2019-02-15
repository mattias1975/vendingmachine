﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMashine

{
    abstract class Money
    {
        public int Worth { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Worth + " " + Name;
        }
    }
}

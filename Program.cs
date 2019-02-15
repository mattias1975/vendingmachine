using System;
using System.Collections.Generic;


namespace VendingMashine
{
    class Program
    {

        public void Main(string[] args)
        {
            Soda fanta = new Soda("Yellow", "Soda", 9);
            Soda cocca = new Soda("black", "Caffeine", 10);
            Soda rassberysoda = new Soda("red", "Soda", 7);

            Coffe nordqvist = new Coffe("Black", 7, 34);
            Coffe zoegas = new Coffe("Black", 7, 37);
            Coffe gevalia = new Coffe("Brown", 6, 43);

            Chocolate japp = new Chocolate("dark", "Taste good", 10);
            Chocolate Snickers = new Chocolate("medium dark", "OK", 12);
            Chocolate twix = new Chocolate("dubble", "taste Good", 11);

           
        }

    }

} 

using System;
using System.Collections.Generic;
using VendingMachine;

namespace VendingMashine
{
    class Program
    {

        public static void Main(string[] args)
        {

            string money;

            Soda fanta = new Soda("Fanta price 11 ", 11, "Yellow", 9);
            Soda cocca = new Soda("Coka cola price 12", 12, "black", 10);
            Soda rassberysoda = new Soda("rassberysoda price 8", 8, "red", 7);

            Coffe nordqvist = new Coffe("Arvid Nordqvist price 34", 7, "black", 34);
            Coffe zoegas = new Coffe("Zoegas price 37", 37, "black", 37);
            Coffe gevalia = new Coffe("Gevalia price 34", 34, "brown", 43);

            choclate japp = new choclate("Japp price 10", 10, "Taste good", 44);
            choclate Snickers = new choclate("Snickers price 12", 12, "OK", 45);
            choclate twix = new choclate("Twix price 11", 11, "good ", 12);

            List<Product> product = new List<Product>
            {
              fanta,cocca,rassberysoda, nordqvist,zoegas,gevalia,japp,Snickers,twix
            };

            foreach (var item in product)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("How much money will you putt in?,\n 1kr, 5kr,10kr,20kr,50kr,100kr,500kr,1000kr");
            money = Console.ReadLine();
            Convert.ToInt32(32);









        }

    }

}

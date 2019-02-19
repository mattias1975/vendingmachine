using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    abstract class Product
    {
        static int countId = 1;

        public int Id { get; private set; }//ger ett unikt id och sätter de privat så man ej kan se de utifrån
        public string Name { get; set; }//Name som finns för alla produkter sätts här
        public int Price { get; set; }//samma som namn

        public Product(string name, int price)
        {
            Id = countId++;//plussar på idet med 1 per produkt
            Name = name;// initierar variablen name
            Price = price;//samma som ovan men med price
        }
        
       
        public override string ToString()
        {
            return Id + ": " + Name;//returnerar id och name till en string
       
        }
        
    }
}

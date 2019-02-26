using VendingMachine;

namespace VendingMashine
{
    class Coffe : Product
    {
        protected string color;
        protected double size;
        public Coffe(string name, int price, string color, int size) : base(name, price)
        {
            this.color = color;

            this.size = size;

        }


    }
}





namespace VendingMachine
{
    internal class Soda : Product
    {


        public Soda(string name, int currentValue) : base(name, currentValue)
        {
        }

        internal override void Examine()
        {
            Console.WriteLine($"It cost 20:- {Name}");
        }

        internal override void Use()
        {
            Console.WriteLine("Drink it by unscrewing the top");
        }
    }
}
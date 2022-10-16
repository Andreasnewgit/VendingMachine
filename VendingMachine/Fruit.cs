

namespace VendingMachine
{
    public class Fruit : Product
    {
        public Fruit(string name, int currentValue) : base(name, currentValue)
        {
        }


        internal override void Examine()
        {
            Console.WriteLine($"It is a yellow banana costs 10:-");
        }

        internal override void Use()
        {
            Console.WriteLine("Eat it by peeling the skin first");
        }
    }
}
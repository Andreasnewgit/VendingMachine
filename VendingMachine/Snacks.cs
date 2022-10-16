

namespace VendingMachine
{
    internal class Snacks : Product
    {

        public Snacks(string name, int currentValue) : base(name, currentValue)
        {
        }

        internal override void Examine()
        {
            Console.WriteLine("Price 25:-, It's a bag of Ostbågar");
        }

        internal override void Use()
        {
            Console.WriteLine("Eat it by opening the bag at the top first");
        }
    }
}
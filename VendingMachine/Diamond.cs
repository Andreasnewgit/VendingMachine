
namespace VendingMachine
{
    internal class Diamond : Product
    {
        public Diamond(string name, int currentValue) : base(name, currentValue)
        {
        }


        internal override void Examine()
        {
            Console.WriteLine($"It is an expensive{Name}, too expensive for a real vending machine costs 10000:-");
        }

        internal override void Use()
        {
            Console.WriteLine("Watch it sparkle");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class ApplicationManager : IVending
    {

        public ApplicationManager()
        {
            Products = new List<Product>();
            CreateProductList();
            _availableFunds = 0;
        }

        Fruit fruit = new Fruit("Banan", 15);
        Snacks snacks = new Snacks("Ostbagar", 25);
        Soda soda = new("Cola", 20);
        Diamond diamond = new("diamond", 1000);

        private int _availableFunds;
        private List<Product> Products { get; set; }
        private int _idForPurchase;
        public void CreateProductList()
        {
            Snacks snacks = new("Ostbågar", 25);
            Products.Add(snacks);

            Soda soda = new("Cola", 20);
            Products.Add(soda);

            Fruit fruit = new("Banan", 10);
            Products.Add(fruit);

            Diamond diamond = new("Diamant", 10000);
            Products.Add(diamond);
        }

        public void ShowAll()
        {
            Console.WriteLine("Products available for purchase");
            foreach (Product item in Products)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Price: {item.CurrentValue}");
            }
        }

        public void PurchaseProduct()
        {

            ShowAll();
            Console.WriteLine("Type the Id for the product you wish to buy");
            int chosenId = int.Parse(Console.ReadLine());

            foreach (Product item in Products)
            {
                if (item.Id == chosenId)
                {
                    if (item.CurrentValue <= _availableFunds)
                    {
                        _idForPurchase = item.Id;
                        _availableFunds -= item.CurrentValue;
                        ShowAvailableFunds();
                        Console.WriteLine("Thank you for buying");
                        if (item.Id == 5) 
                        {
                            snacks.Examine();
                            snacks.Use();
                        }
                        if (item.Id == 6)
                        {
                            soda.Examine();
                            soda.Use();
                        }
                        if (item.Id == 7)
                        {
                            fruit.Examine();
                            fruit.Use();
                        }
                        if (item.Id == 8)
                        {
                            diamond.Examine();
                            fruit.Use();
                        }

                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Not enough money to buy a product. Please add more");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }

        }
        public void InsertMoney()
        {
            
            int amount = 0;
            try
            {
           
                Console.Write("This Machine can only proccess the following ooins and bills 1, 5, 10, 20, 50, 100, 500, 1000" +
                "\nPlease insert money in this format: ");
                amount = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input correct format");
                InsertMoney();
                return;
            }

        int[] allowedInput = new int[8] { 1, 5, 10, 20, 50, 100, 500, 1000 };
            var allowed = false;
            for (var i = 0; i < allowedInput.Length; i++)
            {
               if( allowedInput[i] == amount) {
                    allowed = true;
                }
            }

            if(allowed) { 
                _availableFunds += amount;
                ShowAvailableFunds();
            }
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong input please input 1, 5, 10, 20, 50, 100, 500, 1000 }");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void ShowAvailableFunds()
        {
            Console.WriteLine($"You have {_availableFunds} funds");
        }
        public int EndTransaction()
        {
            {
                var target = _availableFunds;
                var current = 0;
                var kronorDenomination = new[] { 1, 5, 10, 20, 50, 100, 500, 1000 }.OrderByDescending(x => x); // just make sure they're descending.
                var bestWay = new List<int>();

                foreach (var kronorSize in kronorDenomination)
                {
                    while (current + kronorSize <= target)
                    {
                        current += kronorSize;
                        bestWay.Add(kronorSize);
                    }

                    if (current == target)
                        break;
                }

                foreach (var kronor in bestWay)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0}:- ", kronor);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine($"Thank you for using the Vending Machine, your change is {_availableFunds} Kronor");
                Console.ReadLine();
            }
            _availableFunds = 0;
            return _availableFunds;
        }
    }

    public abstract class Product
    {
        public Product(string name, int currentValue)
        {
            Name = name;
            CurrentValue = currentValue;
            _index++;
            Id = _index;
        }

        private static int _index = 0;
        public int Id { get; }

        public string Name { get; set; }
        public int CurrentValue { get; set; }

        internal abstract void Examine();
        internal abstract void Use();
    }
}
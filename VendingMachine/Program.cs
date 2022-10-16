using VendingMachine;


class Program
{
    static void Main(string[] args)
    {
        ApplicationManager applicationManager = new();
        string userSelection;

        // Menu Loop
        do
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("******************");
            Console.WriteLine("*Vending Machine**");
            Console.WriteLine("******************");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("1: Purchase Product");
            Console.WriteLine("2: Show All Products");
            Console.WriteLine("3: Insert Money");
            Console.WriteLine("4: End Transaction and get unspent money back");
            Console.WriteLine("0: Exit Program");
            applicationManager.ShowAvailableFunds();
            userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    applicationManager.PurchaseProduct();
                    break;
                case "2":
                    applicationManager.ShowAll();
                    break;
                case "3":
                    applicationManager.InsertMoney();
                    break;
                case "4":
                    applicationManager.EndTransaction();
                    break;
                case "0": break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
        while (userSelection != "0");

        Console.WriteLine("Thanks for using the Vending Machine!");
        Console.Read();
    }
}





//if (userSelection == "3")
//{
//    Console.Write("Type the amount of money youre inserting, seperated by blankpace: \n" +
//        "1 5 10 20 50 100 500 1000 like this. \n" +
//        ": ");
//    input_1 = Console.ReadLine();
//}

//string[] inputArray = input_1.Split(' ');

//int[] myInts = Array.ConvertAll(input_1.Split(' '), int.Parse);

//int result = 0;
//switch (userSelection)
//{
//    case "1":
//        applicationManager.Purchase();
//        break;
//    case "2":
//        applicationManager.ShowAll();
//        break;
//    case "3":
//        if (myInts.Length > 0)
//        {
//            result = applicationManager.InsertMoney(myInts);
//        }

//        break;
//    case "4":
//        applicationManager.EndTransaction();
//        break;
//    case "0": break;
//    default:
//        Console.WriteLine("Invalid selection. Please try again.");
//        break;
//}



//public int InsertMoney(int[] input)
//{
//    {
//        int result = input[0];
//        for (int i = 0; i < input.Length; i++)
//        {
//            result += input[i];
//        }
//        Console.WriteLine($"You have inserted {result}:-");

//        int insertMoneyResult = result;
//        return insertMoneyResult;
//    }
//}

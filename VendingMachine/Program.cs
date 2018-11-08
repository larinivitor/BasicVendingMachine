using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var drinkMachine = new DrinkingMachine();

            while (!drinkMachine.checkTotal())
            {
                Console.WriteLine("Please enter 1,5,10,25,50,100 cents");
                drinkMachine.DepositCoin(Convert.ToInt32(Console.ReadLine()));
            }

            drinkMachine.DisplayDrinkSelections();

            Console.ReadLine();
        }
    }
}

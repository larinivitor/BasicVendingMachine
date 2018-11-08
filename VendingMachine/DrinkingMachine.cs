using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class DrinkingMachine
    {
        int cokeQuantity = 10;
        const double cokeValue = 150 * 0.01;

        int pastelinaQuantity = 10;
        const double pastelinaValue = 30 * 0.01;

        int waterQuantity = 10;
        const double waterValue = 100 * 0.01;

        const int COST_OF_DRINK = 200;
        bool selectionOk = false;

        public double RunningTotal { get; set; }

        public DrinkingMachine()
        {
            RunningTotal = 0;
        }

        public void DepositCoin(int money)
        {
            switch (money)
            {
                case (1):
                    RunningTotal += 0.01;
                    Console.WriteLine("Total Deposit: {0:C}", RunningTotal);
                    Console.WriteLine();
                    DisplayDrinkSelections();
                    Console.WriteLine();
                    break;
                case (5):
                    RunningTotal += 0.05;
                    Console.WriteLine("Total Deposit: {0:C}", RunningTotal );
                    Console.WriteLine();
                    DisplayDrinkSelections();
                    Console.WriteLine();
                    break;
                case (10):
                    RunningTotal += 0.10;
                    Console.WriteLine("Total Deposit: {0:C}", RunningTotal);
                    Console.WriteLine();
                    DisplayDrinkSelections();
                    Console.WriteLine();
                    break;
                case (25):
                    RunningTotal += 0.25;
                    Console.WriteLine("Total Deposit: {0:C}", RunningTotal);
                    Console.WriteLine();
                    DisplayDrinkSelections();
                    Console.WriteLine();
                    break;
                case (50):
                    RunningTotal += 0.50;
                    Console.WriteLine("Total Deposit: {0:C}", RunningTotal);
                    Console.WriteLine();
                    DisplayDrinkSelections();
                    Console.WriteLine();
                    break;
                case (100):
                    RunningTotal += 1.00;
                    Console.WriteLine("Total Deposit: {0:C}", RunningTotal);
                    Console.WriteLine();
                    DisplayDrinkSelections();
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }

        public bool checkTotal()
        {
            if (RunningTotal >= COST_OF_DRINK)
                return true;
            else
                return false;
        }

        public void DisplayDrinkSelections()
        {
            Console.WriteLine("C - Coke");
            Console.WriteLine("P - Pastelina");
            Console.WriteLine("W - Water");
            Console.WriteLine();
            Console.WriteLine("Make your selection");
            MakeDrinkSelection(Convert.ToChar(Console.ReadLine().ToUpper()));
        }

        private void checkCoke()
        {
            if (RunningTotal >= cokeValue)
            {
                if (cokeQuantity > 0)
                {
                    Console.WriteLine("Thank you for choosing a Coke");
                    cokeQuantity -= 1;
                    Console.WriteLine("Your change is {0:C}", (RunningTotal - cokeValue));
                    RunningTotal = 0;
                    selectionOk = true;
                }
                else
                    Console.WriteLine("Sorry, we are out of Coke");
            }
            else
            {
                Console.WriteLine("Sorry, the Coke value its 1,5");
                Console.WriteLine("Please insert more money: ");
                DepositCoin(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine();
            }
        }

        private void checkPastelina()
        {
            if (RunningTotal >= pastelinaValue)
            {
                if (pastelinaQuantity > 0)
                {
                    Console.WriteLine("Thank you for choosing a Pastelina");
                    pastelinaQuantity -= 1;
                    Console.WriteLine("Your change is {0:C}", (RunningTotal - pastelinaValue));
                    RunningTotal = 0;
                    selectionOk = true;
                }
                else
                    Console.WriteLine("Sorry, we are out of Pastelina");
            }
            else
            {
                Console.WriteLine("Sorry, the Pastelina value its 0,30");
                Console.WriteLine("Please insert more money: ");
                DepositCoin(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine();
            }
        }

        private void checkWater()
        {
            if (RunningTotal >= waterValue)
            {
                if (waterQuantity > 0)
                {
                    Console.WriteLine("Thank you for choosing a Water");
                    waterQuantity -= 1;
                    Console.WriteLine("Your change is {0:C}", (RunningTotal - waterValue));
                    RunningTotal = 0;
                    selectionOk = true;
                }
                else
                    Console.WriteLine("Sorry, we are out of Water");
            }
            else
            {
                Console.WriteLine("Sorry, the Water value its 1,00");
                Console.WriteLine("Please insert more money: ");
                DepositCoin(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine();
            }
        }

        private void MakeDrinkSelection(char selection)
        {
            while (!selectionOk)
            {
                switch (selection)
                {
                    case 'C':
                        checkCoke();
                        break;
                    case 'P':
                        checkPastelina();
                        break;
                    case 'W':
                        checkWater();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection.");
                        selection = Convert.ToChar(Console.ReadLine().ToUpper());
                        selectionOk = false;
                        break;
                }
            }
        }
    }
}

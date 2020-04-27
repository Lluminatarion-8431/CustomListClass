using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class CoffeeShop
    {
        // member variables (HAS A)
        private List<CoffeeCup> coffeeCups; // the shop has 5 cups of coffee to sell

        // constructor (SPAWNER)
        public CoffeeShop()
        {
            coffeeCups = new List<CoffeeCup>();

            for(int i = 0; i < 5; i++)
            {
                CoffeeCup cupOfCoffee = new CoffeeCup();
                coffeeCups.Add(cupOfCoffee);
            }
        }

        // member methods (CAN DO)
        public CoffeeCup SellCoffeeCup()
        {
            GreetCustomer();

            if(coffeeCups.Count > 0)
            {
                string customerResponseToBuyingCoffee = AskCustomerToBuyCoffee();

                if (customerResponseToBuyingCoffee == "yes")
                {
                    CoffeeCup coffeeToSell = coffeeCups[0];
                    coffeeCups.RemoveAt(0);

                    return coffeeToSell;
                }
                else
                {
                    Console.WriteLine("Ok! Thanks for visiting! Hope to see you soon!");
                }
            }
            else
            {
                Console.WriteLine("Unfortunately, we are out of coffee...");
            }

            return null;
        }

        private void GreetCustomer()
        {
            Console.WriteLine("Welcome to the coffee shop!");
        }

        private string AskCustomerToBuyCoffee()
        {
            Console.WriteLine("Would you like to purchase a cup of coffee?");
            Console.WriteLine("Please enter 'yes' or 'no'.");
            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}

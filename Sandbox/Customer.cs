using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Customer
    {
        // member variables (HAS A)
        public CoffeeCup cupOfCoffee;
        public int caffineLevel; // scale of 1 - 10

        // constructor (SPAWNER)
        public Customer()
        {
            cupOfCoffee = null;
            caffineLevel = 1;
        }

        // member methods (CAN DO)
        public void DrinkFromCupOfCoffee()
        {
            if(cupOfCoffee != null)
            {
                cupOfCoffee.percentageFull -= 10;
                caffineLevel++;

                if(cupOfCoffee.percentageFull <= 0)
                {
                    cupOfCoffee = null;
                }
            }
        }
    }
}

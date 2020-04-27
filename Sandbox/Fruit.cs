using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox   // always leave this namespace thing alone!
{
    class Fruit     // this is the name of the class you create
    {
        // ALL code for a class goes inside that class' curly brackets!

        // member variables go here:
        public string type;
        public string color;

        // constructor goes here:
        public Fruit()
        {

        }

        // member methods go here:
        public void DisplayFruitType()
        {
            // the logic to make a method work goes here in side the method's curly brackets!
            // when writing the logic for your method, think about what is should do step by step
            // then look into your "code toolbox" to decide what tool(s) might be best for the first step!
            // try to put the first step together, using resources of the tool(s) you are using for reference
            // run and test your attempt, make any adjustments, and try again! then move on to the next step

            Console.WriteLine("This fruit is a " + type);
        }

        public void DisplayPrimeNumbers()
        {
            Console.WriteLine(2);

            for(int i = 3; i < 101; i+=2)
            {
                // inner for loop, test for primeness, etc
            }

        }

    }

}

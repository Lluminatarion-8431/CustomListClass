using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Assessment
    {
        //////////////////////////////////////////////////////////
        // 1) What is a variable?

        // 2) What is a method?

        // 3) What is a for loop?

        // 4) What is a if statement?

        // 5) What will the following code print to the console?
        public void QuestionFive()
        {
            string name = "Charles";
            name = "Mike";
            Console.WriteLine(name); // ???
        }

        // 6) What things will print to the console when this method is called?
        public void QuestionSix()
        {
            int x = 5 + 10;
            bool result = CheckIfLegalToDrive(20);
            Console.WriteLine(result);

            bool result2 = CheckIfLegalToDrive(10);
        }
        //////////////////////////////////////////////////////////
        public bool CheckIfLegalToDrive(int age)
        {
            int drivingAge = 16;

            if(age >= drivingAge)
            {
                Console.WriteLine("You are legally able to drive!");
                return true;
            }
            else
            {
                Console.WriteLine("Not old enough to drive yet.");
                return false;
            }
        }
    }
}

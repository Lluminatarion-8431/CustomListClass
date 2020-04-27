using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Day5Quiz
    {        

        public double CalculatePay()
        {
            Console.WriteLine("Please enter your hours worked:");
            string hoursWorkedInput = Console.ReadLine();

            Console.WriteLine("Please enter your hours worked:");
            string payRateInput = Console.ReadLine();

            int hoursWorked = int.Parse(hoursWorkedInput);
            double payRate = double.Parse(payRateInput);

            double totalPay = hoursWorked * payRate;

            return totalPay;
        }

        public void PrintUserName()
        {
            Console.WriteLine("Please enter your name:");

            string userInput = Console.ReadLine();

            Console.WriteLine("Your name is " + userInput);
        }

        public void DisplayIncomingMessage(string incomingMessage)
        {
            Console.WriteLine(incomingMessage);
        }

        // Q1

        public int GetTriangleArea(int triangleHeight, int triangleWidth)
        {
            int triangleArea = triangleHeight * triangleWidth / 2;
            return triangleArea;
        }
        
        // Q2

        public int CalculateNewScore(int dieRoll, int currentScore)
        {
            if(dieRoll % 2 == 0)
            {
                if(dieRoll <= 3)
                {
                    currentScore -= dieRoll;
                }
                else
                {
                    currentScore += (dieRoll * 2);
                }
            }
            else
            {
                if(dieRoll <= 3)
                {
                    currentScore -= (dieRoll * 2);
                }
                else
                {
                    currentScore += dieRoll;
                }
            }

            return currentScore;
        }

        // Q3

        public int CountEligibleDrivers(List<int> driverAges)
        {
            int legalDrivingAge = 16;
            int eligibleDriverCount = 0;

            for(int i = 0; i < driverAges.Count; i++)
            {
                if(driverAges[i] >= legalDrivingAge)
                {
                    eligibleDriverCount++;
                }
            }

            return eligibleDriverCount;
        }
    }
}

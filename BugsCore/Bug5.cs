using System;
using System.Collections.Generic;
using System.Text;

namespace Bugs
{
    public class Bug5 : IBug
    {
        public void Run()
        {
            while (true)
            {
                double yourMoney = 100000;
                double myMoney = 100000;
                Console.WriteLine("We each have ${0}. Transfer me some money.", yourMoney);
                Console.WriteLine();
                // Get a number from the user
                var input = Console.ReadLine();
                if (input == "q")
                {
                    // The user wants to quit
                    break;
                }

                // Convert it to a floating point number
                if (!double.TryParse(input, out double x))
                {
                    Console.WriteLine("Not a number");
                    continue;
                }

                if (x <= 0)
                {
                    Console.WriteLine("Amount must be positive");
                }
                else if (x > yourMoney)
                {
                    Console.WriteLine("You don't have enough money to pay for that");
                }
                else // 0 < x < yourMoney
                {
                    yourMoney -= x;
                    myMoney += x;
                    Console.WriteLine("You have ${0:0.00}. I have ${1:0.00}", yourMoney, myMoney);
                    if (myMoney > yourMoney)
                    {
                        Console.WriteLine("I have more money than you. I win");
                    }
                    else
                    {
                        Console.WriteLine("You win");
                    }
                }
            }
        }
    }
}
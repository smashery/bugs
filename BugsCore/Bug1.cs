using System;

namespace Bugs
{
    public class Bug1 : IBug
    {
        public void Run()
        {
            while (true)
            {
                long yours = 10000; // Dollars
                long mine = yours;
                Console.WriteLine("You and I both have ${0}. Transfer me some money.", yours);

                string input = Console.ReadLine(); // Get something from the user
                if (input == "q")
                {
                    // Quit
                    return;
                }

                // Turn the user's input into a number
                if (int.TryParse(input, out int amountToTake))
                {
                    // Ensure it's positive
                    if (amountToTake < 0)
                    {
                        Console.WriteLine("Negative number. Swapping to positive");
                        amountToTake = -amountToTake;
                    }
                    if (amountToTake > yours) // Ensure they have enough money
                    {
                        Console.WriteLine("You don't have that much money");
                    }
                    else
                    {
                        yours = yours - amountToTake;
                        mine = mine + amountToTake;

                        Console.WriteLine("You have ${0}. I have ${1}.", yours, mine);
                        if (yours > mine)
                        {
                            Console.WriteLine("You win");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid int value");
                }
                Console.WriteLine();
            }
        }
    }
}
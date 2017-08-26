using System;
using System.Collections.Generic;
using System.Text;

namespace Bugs
{
    public class Bug0 : IBug
    {
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Pick a number");
                
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

                DivideThenMultiply(x);
            }
        }

        private void DivideThenMultiply(double number)
        {
            var original = number;

            number /= 7;
            Console.WriteLine("{0} divided by 7 is {1}", original, number);
            Console.ReadLine();

            number /= 3;
            Console.WriteLine("Divided by 3 is {0}", number);
            Console.ReadLine();

            number *= 7;
            Console.WriteLine("Multiplied by 7 is {0}", number);
            Console.ReadLine();

            number *= 3;
            Console.WriteLine("Multiplied by 3 is {0}", number);
            Console.ReadLine();

            bool areEqual = number == original; // (True or False)

            Console.WriteLine("Comparing to original number: {0} is {1}equal to {2}", number, areEqual ? "" : "NOT ", original);
            Console.WriteLine();
        }
    }
}

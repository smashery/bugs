using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Bugs
{
    public class Bug2 : IBug
    {
        public void Run()
        {
            while (true)
            {
                double myMoney = 100_000;
                Console.WriteLine("I have ${0} in my account\r\n", myMoney);
                Console.Write("You can make one transaction out of my account, as long as it is less than $1000: How much do you want to take?\r\n$");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }

                // This next bit is a Regular Expression, or "Regex"
                // Regexes are used to do pattern-matching on strings.
                //
                // tl;dr - All this does is check "Do you have a one-, two- or
                //         three -digit number, optionally followed by a full 
                //         stop and two more digits (the cents)"
                //         It isn't the bug you're looking for, though you 
                //         should at least understand what it achieves.
                //         
                // The long version:
                // With a regex, you define a "pattern" (which is the 
                // complicated-looking thing just below), and then ask
                // it "does this other string match the pattern?"
                // It can look confusing, but in this case, the Regex is just asking:
                // Does your input:
                // 1. Start with 1-3 digits (e.g. anything between 0 and 999)
                // 2. Then, optionally, have a dot and two more digits: the number
                //    of cents (e.g. ".99")
                // 3. Have nothing else after that
                // 
                // If it doesn't match this pattern, then it won't do the transfer.
                // So it will match the following:
                // "1", "12", "123", "1.23", "12.34", "123.45", "000.00"
                // It will not match any of the following:
                // "1234", "1.2", "hello", "123.456"
                // 
                // The technical version:
                // "\d" means "match any decimal digit"
                // "\." means "match the '.' character"
                // "{1,3}" means "match the previous symbol (in this case, a digit) 
                //                between 1 and 3 times"
                // "?" means "the previous bit (the cents bit) is optional"
                // "^" and "$" mean that your text can't have anything else before or after it
                // Parentheses just group stuff together as logical groups
                Regex pattern = new Regex(@"^((\d){1,3}(\.\d\d)?)$");

                if (pattern.IsMatch(input)) // Check it is a valid
                {
                    var num = double.Parse(input);
                    myMoney -= num;
                    Console.WriteLine("I have ${0} in my bank\r\n", myMoney);
                    if (myMoney > 99_000)
                    {
                        Console.WriteLine("I'm still rich. I win.");
                    }
                    else
                    {
                        Console.WriteLine("I'm financially ruined! You win.");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Input does not match pattern");
                }
            }
        }
    }
}
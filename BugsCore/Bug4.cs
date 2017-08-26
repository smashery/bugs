using Bugs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bugs
{
    public class Bug4 : IBug
    {
        public void Run()
        {
            var start = DateTime.Now;
            long total = 0;
            long num = 1000000000;
            Console.WriteLine("Calculating the sum of the first {0} digits", num);
            Console.WriteLine("Starting timer...");
            // Yeah, I know, there's a formula for doing this.
            for (long x = 0; x < num; ++x)
            {
                total += x;
            }
            var end = DateTime.Now;
            var duration = end - start;
            Console.WriteLine("Total is {0}", total);
            Console.WriteLine("Took {0}ms", duration.TotalMilliseconds);
            if (duration.TotalMilliseconds < 5)
            {
                // Maybe they had a supercomputer?
                Console.WriteLine("You win");
            }
            else
            {
                Console.WriteLine("Too slow");
            }
        }
    }
}

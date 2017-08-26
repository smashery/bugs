using System;
using System.IO;

namespace Bugs
{
    public class Bug3 : IBug
    {
        public void Run()
        {
            // Challenge:
            // Create a file that causes this naive string reverse function
            // to produce a result that doesn't really make sense
            var forwardsPath = @"forwards.txt";
            var backwardsPath = @"backwards.txt";
            if (File.Exists(forwardsPath))
            {
                var s = File.ReadAllText(forwardsPath);
                File.WriteAllText(backwardsPath, Reverse(s), System.Text.Encoding.UTF8);
                Console.WriteLine("Written to backwards.txt");
            }
            else
            {
                Console.WriteLine("Could not find forwards.txt");
            }
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
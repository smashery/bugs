using System;

namespace Bugs
{
    class Program
    {
        static IBug[] _bugs = { new Bug0(), new Bug1(), new Bug2(), new Bug3(), new Bug4(), new Bug5() };
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a bug number (0 to {0})", _bugs.Length - 1);
                    var bugNumStr = Console.ReadLine();
                    if (bugNumStr == "q")
                    {
                        break;
                    }
                    if (int.TryParse(bugNumStr, out int bugNum) && bugNum < _bugs.Length)
                    {
                        _bugs[bugNum].Run();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("CRASH!!!");
                    Console.WriteLine(e.Message);
                }
            }
        }


    }
}
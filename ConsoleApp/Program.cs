using System;
using ConsoleUtilities;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Utilities utilities = new Utilities();
            string stringOutput = "Hello Dana!";
            utilities.writeline(stringOutput);
            Console.ReadKey();
        }
    }
}

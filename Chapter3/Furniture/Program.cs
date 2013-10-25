using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("type P for Pine O for Oak M for Mahogany");
            input = Console.ReadLine();

            if (input == "P")
            {
                Console.WriteLine("price is $100");
            }

            if (input == "O")
            {
                Console.WriteLine("price is $225");
            }

            if (input == "M")
            {
                Console.WriteLine("price is $310");
            }

            if (input != "P" && input != "O" && input != "M")
            {
                Console.WriteLine("price is $0");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3
{
    class checkzip
    {
        static void main(string[] args)
        {
            string input;
            int counter = 0;

            int[] zipcodes = new int[10] { 18041, 18042, 18043, 18044, 18045, 18046, 18047, 18048, 18049, 18050 };

            for (int i = 0; i < zipcodes.Length; i++)
            {
                Console.WriteLine(zipcodes[i]);
            }

            while (counter < zipcodes.Length)
            {
                Console.WriteLine(zipcodes[counter]);
                counter++;
            }

            Console.WriteLine("type your zip code");

            input = Console.ReadLine();

            for (int i = 0; i < 100; i++) ;
            {

                if (input == zipcodes[i])
                {
                    Console.WriteLine("we can dieliver to your area");
                }
                else
                {
                    Console.WriteLine("we can not delever to your area");
                }
            }
        }
    }
}

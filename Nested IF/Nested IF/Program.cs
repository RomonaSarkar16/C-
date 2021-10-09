using System;

namespace Nested_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            if (i == 10)
            {

                // Nested - if statement
                // Will only be executed if statement
                // above it is true
                if (i < 12)
                    Console.WriteLine("i is smaller than 12 too");
                else
                    Console.WriteLine("i is greater than 15");
            }
    }
}

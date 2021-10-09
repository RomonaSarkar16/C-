using System;

namespace Nested_for
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a;
            for (a = 1; a <= 4; a++)
            {
                Console.WriteLine("For Loop " + a);
                for (int k = 0; k <= 2; k++)
                {
                    Console.WriteLine("Nested for Loop " + k);
                }
            }
            Console.WriteLine("OUT");
        }
    }
}

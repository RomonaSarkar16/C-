using System;

namespace Jump_Statement_1
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int a =1;a<5;a++)
            {
                switch(a)
                {
                    case 1:
                        Console.WriteLine("In case 1");
                        goto case 3;
                    case 2:
                        Console.WriteLine("In case 2");
                        goto case 1;
                    case 3:
                        Console.WriteLine("In case 3");
                        goto default;
                    default:
                        Console.WriteLine("In default");
                        break;


                }
                Console.WriteLine();
            }
        }
    }
}

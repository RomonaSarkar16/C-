using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12;
          

            Console.WriteLine("Arithematic Operators ----");
            Console.WriteLine("Addition Operator : "+ (x+y));
            Console.WriteLine("Substraction Operator : " + (x - y));
            Console.WriteLine("Multiplication Operator:" + (x*y));
            Console.WriteLine("Division Operator:" + (x / y));
            Console.WriteLine("Modulo Operator:" + (x %y));

            Console.WriteLine("Unary Operators-------");
            

            x++;
            y++;

            Console.WriteLine("Increment of x {0} and y {1}" , x++ , y++);
            --x;
            --y;

            Console.WriteLine("Decrement of x {0} and y {1}", --x, --y);
            Console.WriteLine();
            Console.WriteLine("Logical operators------");

            Console.WriteLine(true & false);
            Console.WriteLine(true & true);
            Console.WriteLine(false & false);
            Console.WriteLine(true || false);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);
            Console.WriteLine(!false);
            Console.WriteLine(!true);
            bool b1 = true, b2 = false,res;
           
            res = b1 && b2;
            Console.WriteLine("And :" + res);
            res = b1 || b2;
            Console.WriteLine("OR :" + res );
            res = !b1;
            Console.WriteLine("Not : " + res);





        }
    }
}

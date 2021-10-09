using System;

namespace PassByvalue__and_PassByRef
{
    class Program
    {
        public static void add(int a)
        {
            a = a + 100;
            Console.WriteLine("Inside the Method : " + a);
        }
        public static void Multiply(ref int b)
        {
            b = b * 100;
            Console.WriteLine("Inside the Multiply method : "+ b);
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
           
            
            Console.WriteLine("Before using method : " + a);
            add(20);

            Console.WriteLine("After calling Add method : " + a);
            Console.WriteLine();
            Console.WriteLine("Before using method : " + b);
            Multiply(ref b);
            Console.WriteLine("After using Ref and calling Multiply  method : " + b);

        }
    }
}

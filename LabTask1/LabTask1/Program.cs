using System;

namespace LabTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name : Romona Magdalene Sarkar");
            Console.WriteLine("Student ID: 20-42186-1");
           

            char C = 'A';
            int myC = C;
            Console.WriteLine("_____Implicit Casting_____");
            Console.WriteLine("Character : " + C);
            Console.WriteLine("Character to Integer : "+myC);

            double myD = 12.22;
            int myInt = (int) myD;

            Console.WriteLine("______Explicit Casting______");
            Console.WriteLine("Double number : "+myD);
            Console.WriteLine("Double to Integer : "+myInt);
            Console.ReadKey();





        }
    }
}

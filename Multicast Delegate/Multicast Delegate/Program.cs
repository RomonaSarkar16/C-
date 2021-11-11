using System;

namespace Multicast_Delegate
{
    public delegate void MulticastDelegate(int a, int b);

    class Calculation
    {
        public void Addition(int a, int b)
        {
            Console.WriteLine("Addition Result = " + (a + b));
        }

        public void Subtraction(int a, int b)
        {
            Console.WriteLine("Subtraction Result = " + (a - b));
        }
        public void Multiplication(int a, int b)
        {
            Console.WriteLine("Multiplication Result = " + (a * b));
        }
        public void Division(int a, int b)
        {
            Console.WriteLine("Division Result = " + (a / b));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculation Cal = new Calculation();

            MulticastDelegate del = Cal.Addition;

            del += Cal.Subtraction;
            del += Cal.Multiplication;
            del += Cal.Division;

            del(23,21);

        }
    }
}

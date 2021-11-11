using System;

namespace Single_Delegate
{
    //Delegate declare
    public delegate void SingleDelegate(int a, int b);
    class Calculation
    {
        public void Addition(int a,int b)
        {
            Console.WriteLine("Addition Result = "+ (a+b));
        }

        public void Subtraction(int a,int b)
        {
            Console.WriteLine("Subtraction Result = " + (a - b));
        } 
        public void Multiplication(int a,int b)
        {
            Console.WriteLine("Multiplication Result = " + (a * b));
        } 
        public void Division(int a,int b)
        {
            Console.WriteLine("Division Result = " + (a / b));
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculation Cal = new Calculation();
            Cal.Addition(21,23); //usual approach

            //using Delegate
            Console.WriteLine("__Delegate__");

            SingleDelegate del = Cal.Addition;
            del(21,23);

            del = Cal.Subtraction;
            del(23,21);

            del = Cal.Multiplication;
            del(21,23); 
            
            del = Cal.Division;
            del(2,2);



        }
    }
}


using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write(" OH ! Darling What's your Name : ");
            string inp= Console.ReadLine();
            Console.WriteLine("My name is " +  inp);
            Console.WriteLine("whats the year ? ");
            string age = Console.ReadLine();
            Console.WriteLine("yess! And This January I will be " + (Convert.ToInt32(age) - 2000));

        }
    }
}

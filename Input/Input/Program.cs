using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name : ");
            string username = Console.ReadLine();
            Console.WriteLine("Your Name : " + username);
            Console.ReadLine();

            Console.WriteLine("enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age : " + age);
            Console.ReadLine();

        }
    }
}

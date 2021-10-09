using System;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___NiD Registration___");

            Console.WriteLine("Enter your Age : ");
            string age = Console.ReadLine();
            int Age = Convert.ToInt32(age);
            
            if (Age > 17) 
            {
                Console.WriteLine("Start Registration for Your NID");
            }
            else if (Age == 17)
            {
                Console.WriteLine("Need to wait for your Legal age");
            }
            else if (Age < 10)
            {
                Console.WriteLine("Kid Stay out Of this !");
            }
            else
            {
                Console.WriteLine("Sorry Not Possible U are not adult .");
            }

            int time = 22;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}

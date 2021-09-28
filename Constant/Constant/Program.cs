using System;

namespace Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string age = Console.ReadLine();
            Console.WriteLine("Your Age : " + age);
            const long Nid = 911692345;
            //Nid = 12083949357;
            //when we use constant it cannot be updated later!!!

            Console.WriteLine("Nid :" + Nid);

        }
    }
}

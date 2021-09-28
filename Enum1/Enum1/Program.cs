using System;

namespace Enum1
{
    class Program
    {
        enum Days { Sun,mon,tue,wed,thur,fri,sat}
        static void Main(string[] args)
        {
            Days d = Days.Sun;

            //Console.WriteLine("__Class Routine Day__ ");
            //Console.WriteLine("Enter your day : ");
            //string day = Console.ReadLine();
            //Console.WriteLine("Here is your routine " + day);
            switch(d)
            {
                case Days.Sun:
                    Console.WriteLine("Its your class day");
                    break;

                case Days.mon:
                    Console.WriteLine("Its your Class Day");
                    break;
                case Days.tue:
                    Console.WriteLine("Its your Class Day");
                    break;
                case Days.wed:
                    Console.WriteLine("Its your Class Day");
                    break;
                case Days.thur:
                    Console.WriteLine("Off day");
                    break;
                case Days.fri:
                    Console.WriteLine("Off day");
                    break;
                case Days.sat:
                    Console.WriteLine("Off day");
                    break;


            }
           

        }
    }
}

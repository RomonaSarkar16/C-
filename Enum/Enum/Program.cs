using System;

namespace Enum
{
    class Program
    {
        enum Days { Sunday, Monday, Tuesday = 12, Wednesday = 21, Thursday }
        static void Main(string[] args)
        {
            Days d = Days.Thursday;
            int a = (int)Days.Thursday;
            Console.WriteLine("Day:"+d);
            Console.WriteLine("location:"+a);
            
        }
    }
}

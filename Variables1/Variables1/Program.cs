using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables and datatypes
            //byte,sbyte,string,int,double,float,decimal,var,bool,char,long,uint,ulong,short,ushort,const
            string Name = "Angela Sarkar";
            Console.WriteLine(Name);
            int age = 21;
            Console.WriteLine(age);
            double d1 = 21.9;
            Console.WriteLine( d1);
            char Gender = 'F';
            Console.WriteLine(Gender);
            bool isadult = true;
            Console.WriteLine("she is an adult", isadult);

            long number = 123456L;
            Console.WriteLine(number);
            
            //8 bit unsigned int type variable

            uint add = 10;
            Console.WriteLine(add);

            ulong L1 = 1234L;
            Console.WriteLine(L1);

            Console.ReadLine();

            short s = 10;
            Console.WriteLine(s);
            Console.ReadLine();


            float f = 12.4f;
            const int ct = 10;
            //ct = 20;

            var v1 = 3.90f;
            var v2 = 11;

            Console.WriteLine("value of v1 {0},type {1}",v1,v1.GetType());
            Console.WriteLine("Value of v2 {0}, type {1}", v2, v2.GetType());

            Console.ReadLine();

            byte n = 10;
            sbyte N = -10;

            Console.WriteLine(n);
            Console.WriteLine(N);
            Console.ReadLine();

            decimal price, discount;
            price = 200m;
            discount = 7m;

            Console.WriteLine("Price of a shoe " + price + "\nDiscount :" + discount);
            Console.ReadLine();


        }
    }
}

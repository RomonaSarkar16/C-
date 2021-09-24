using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpyeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Implicit Casting(automatically) -converting a smaller type to a larger type size
             char -> int -> long -> float -> double */

            
            int my_int = 444;
            double my_double = my_int; 

            Console.WriteLine(my_int);
            Console.WriteLine(my_double);
            Console.ReadLine();
            
            /*Explicit Casting(manually) - converting a larger type to a smaller size type
             double -> float -> long -> int -> char */
            double myDouble = 33.4;
            int my_Int= (int) myDouble;

            Console.WriteLine(myDouble);
            Console.WriteLine(my_Int);

            Console.ReadLine();

            ///////////
            ///

            int a = 22;
            float f = 12.2f;
            double d = 22.2;
            bool b = true;

            Console.WriteLine(Convert.ToInt32(d));
            Console.WriteLine(Convert.ToString(a));
            Console.WriteLine(Convert.ToBoolean(f));
            Console.WriteLine(Convert.ToString(d));
            Console.WriteLine(Convert.ToDouble(a));

            Console.ReadLine();
        

        }
    }
}

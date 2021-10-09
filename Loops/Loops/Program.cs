using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //While loops
            /* In Programming languages, Loops are used to execute a set of instructions
            functions repeatedly when some conditions become true*/
            int i=0, sum = 0;
            while (i <= 5)
            {
                Console.WriteLine(i);
                sum = sum + i;
                i++;

                Console.WriteLine("Sum of all 5 number :" + sum);

                //for loops
                //syntax:
                //for(initialization,condiion checking,updation)
                for(int b = 1; b<=5; b++)
                {
                    Console.WriteLine("person :"+b);
                }

                // Nested for loops
                /*
                 * if a=0,1 loop out
                 * if a =2 for loop
                 * enter --> nested k=0,k=1,k=2 ---> nested loop out
                 * again a=3 --> nested loop k=0,k=1,k=2 ---> nested loop out
                 * again a=4 --> nested loop k=0,k=1,k=2 ---> nested loop out
                 *then Out
                 */

                int a;
                for (a = 1; a <= 4; a++)
                {
                    Console.WriteLine("For Loop " + a);
                    for (int k = 0; k <= 2; k++)
                    {
                        Console.WriteLine("Nested for Loop " + k);
                    }
                }
                Console.WriteLine("OUT");

                //do-while loop

                /*
                 do-while loop is used to iterate a part of the program several times.
                       if the number of iteration is not fixed and you must have to execute
                      the loop at once ,It is recommended to use do-while loop.
                  */
                // Infinitive do -while loops

            //do
            //{
            //    Console.WriteLine("Infinitive do-while loops");
            //} while (true);


                int m = 0;
                do
                {
                    Console.WriteLine("Do-While Loop__");
                    m++;
                }
                while (m<=2);

                //it will give output at least one time
                int k1 = 1;
                do
                {
                    Console.WriteLine(" DO-While One Time");
                    k1++;

                } while (k1 <= 0);


                //Infinitive for loop
                //for(; ; )
                //{
                //    Console.WriteLine("Infinitive for loop");
                //}


                int Addition = 0;
                int[] num = new int[5];

                for(int c=0;c<5;c++)
                {
                    num[c] = c;
                }
                foreach(int x in num )
                {
                    Console.WriteLine("Value are : " + x);
                    Addition = Addition + x;
                }
                Console.WriteLine("Total Sum = " + Addition);

                Console.ReadLine();










            }
        }
    }
}

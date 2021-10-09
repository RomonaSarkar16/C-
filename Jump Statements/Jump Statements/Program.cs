using System;

namespace Jump_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*There are five keywords in the Jump Statements:

            break , continue ,goto, return , throw
  
            */
            //Continue Statement

            /*
        The Continue Statement is used in loop control structure when you
        need to jump to the next iteration of the loop immediately.It can be
        used with for/while loop.
         */
            Console.WriteLine("For loop Continue statement");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine("Starting:" + j);
                if (j == 5)
                {
                    //using continue statement
                    continue;//it will skip the rest statement
                }
                Console.WriteLine("Skip if for loop condition:" + j);
            }
            Console.WriteLine("While loop Continue statement");
            int x = 1;
            while (x <= 10)
            {
                Console.WriteLine("Starting while:" + x);
                if (x == 5)
                {
                    x++;
                    continue;
                }
                Console.WriteLine("Skip if on while loop condition:" + x);
                x++;

            }
            Console.WriteLine("Do-while loop continue statement");
            int z = 1;
            do
            {
                Console.WriteLine("Starting of do-while loop:" + z);
                if (z == 5)
                {
                    z++;
                    continue;
                }
                Console.WriteLine("Skip if on do-while loop condition:" + z);
                z++;

            } while (z <= 10);

            int k1 = 1;
            do
            {
                if (k1 == 5)
                {
                    k1++;
                    continue;
                }
                Console.WriteLine("One time:" + k1);
                k1++;

            } while (k1 <= 0);

            //Break Statement
            /*
             When a break statement is encountered inside a loop,the loop is immediately
        terminated and the program control resumes at the next statement following the loop.
             */
            Console.WriteLine("For loop break statement:");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(j);//1 to 5 will be printed
                if (j == 5)
                {
                    break;
                }
                Console.WriteLine(j);//1 to 4 will be printed
            }


        }
    }
}



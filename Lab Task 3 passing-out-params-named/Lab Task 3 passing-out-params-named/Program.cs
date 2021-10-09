using System;

namespace Lab_Task_3_passing_out_params_named
{
    class Program
    {
        public static void Addition( int ID,int last_part)
        {
          
            ID = ID + last_part;
            Console.WriteLine("inside the method additon : " + ID);
        }
        public static void Multiply(ref int ID,int last_part)
        {
            
            ID = ID * 7;
            Console.WriteLine("Inside the Method Multiply : " + ID);
        }
        public static void OutPara(out int p)
        {
            //use out when we donot want to initialize in main function. we just initialize it in a method.

            p = 186;
            Console.WriteLine(p);
           
            
        }
        public static void Param(params int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                
                Console.Write(a[i]+ " ");
            }
        }
        //named parameter_______
        public static void Add(int x, double y)
        {
            Console.WriteLine(x+y);
        }

        static void Main(string[] args)
        {
            
            int ID=186;
            int last_part=1;
            Console.WriteLine("--Pass BY Value--");
            Console.WriteLine("before using method Addition :"+ ID); //for out parameter
            Addition(ID,last_part);
            Console.WriteLine("After using method Addition :" + ID);
            Console.WriteLine();
            Console.WriteLine("--Pass BY Reference--");
            Console.WriteLine("before using method Multiply :" + ID); //for out parameter
            Multiply(ref ID, last_part);
            Console.WriteLine("After using method Multiply : " + ID);
            Console.WriteLine();
           
            int p;
            Console.Write("---Out Parameter : ");
            OutPara(out p);
            Console.WriteLine();

            Console.WriteLine("Params Parameter--- :");
            Param(2, 0, 4, 2, 1, 8, 6, 1); //params are used for to avoid the decliaration of many parameters so we use
            //params so that we can take likewise parameters using array
            Console.WriteLine();
            Console.WriteLine();
            //named 
            int a = 10;
            double b = 2;
            Console.Write("Named Parameter : ");
            Add(  y: b,x:a);

            char[][] arr1 = new char[2][];
            arr1[0] = new char[] { 'A','B','C' };
            arr1[1] = new char[] { 'D','E'};
           
            Console.WriteLine("Char Array : ");
            for (int i=0;i<arr1.Length;i++)
            {
                for(int j=0;j<arr1[i].Length;j++)
                {
                    Console.WriteLine("arr1 [" + i + "] [" + j + "] : " + arr1[i][j]);
                }
            }

            arr1[0][2] = 'O' ;
            arr1[1][1] = 'H';

            Console.WriteLine(" After Update Char Array : ");
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    Console.WriteLine("arr1 [" + i + "] [" + j + "] : " + arr1[i][j]);
                }
            }

        }
    }
}

using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // [] -> array notation
            // type []arr, type[] arr
            //[,] - > 2d array, [,,] -> 3d array
            // [row][column] -> jagged array -> array(s) inside array

            int target = 5;
            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            arr1[3 - 2 + 1] = 12;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == target)
                {

                    Console.WriteLine("Found");
                }
                Console.WriteLine("arr[" + i + "] :" + arr1[i]);
            }

            foreach (int i in arr1)
            {
                Console.WriteLine(i);
                //Console.WriteLine(arr1[i]);
                //exception handeled
            }
            //2D array
            int[,] arr2 = new int[,] { { 2, 5 }, { 4, 6 }, { 10, 6 } };
            Console.WriteLine("2D array length " + arr2.Length);
            for (int j = 0; j <3; j++)
            {

                for (int k = 0; k <2; k++)
                {
                    Console.WriteLine("arr2[" + j + "," + k + "] : " + arr2[j, k]);
                }
            }
            foreach(int j in arr2)
            {
                foreach(int k in arr2)
                {
                    Console.WriteLine(j);
                    //Console.WriteLine(k);
                    //Console.WriteLine(j+k);
                }
            }
            //jagged array


            int[][] arr3 = new int[2][];

             arr3[0] = new int[] {1,6,9};
            arr3[1] = new int[] { 0,7};
            Console.WriteLine("3D array arr3[0][2]:"+arr3[0][2]);
            Console.WriteLine("3D array arr3[1][0]:" + arr3[1][0]);

            arr3[0][2] = 4;
            arr3[1][0] = 8;

            for(int i=0;i<arr3.Length;i++)
            {
                for(int j=0;j<arr3[i].Length;j++)
                {
                    Console.WriteLine("arr3 ["+i+"] ["+j+"] : " + arr3[i][j]);
                }
            }
            foreach(int[] i in arr3)
            {
                foreach(int j in i)
                {
                    Console.WriteLine(j);
                }
            }













        }
    }
}

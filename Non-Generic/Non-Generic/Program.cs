using System;
using System.Collections;

namespace Non_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Arr = new ArrayList();
            //collections work with group of objects here add 8 ,55.5 these are objects
            Arr.Add(8 + 6);//add property ,, this is a object
            Arr.Add("I am a student");
            Arr.Add(123.5);//count property

            Console.WriteLine("Count of array list : " + Arr.Count);
            Console.WriteLine("Capacity of the array list : " + Arr.Capacity);

            int A= (int)Arr[0];
            Console.WriteLine("A : "+ A);
            string B = (string)Arr[1];
            Console.WriteLine("B : " + B);

            ArrayList arr1 = new ArrayList() { 100, 100.10, "Angela" };
            Console.WriteLine("Adding 2 arraylist : ");
            Arr.AddRange(arr1);

            Arr.Insert(1,"Romona SArkar");
            Arr.Remove(123.5);
            Arr.RemoveAt(0);
            Console.WriteLine(" DOes this contains in the arraylist : " + Arr.Contains("Romona Sarkar"));
            Console.WriteLine(" DOes this contains in the arraylist : " + Arr.Contains("Romona SArkar"));
            //adding 2 list into Arr object 
            foreach (var i in Arr)
            {
                Console.WriteLine(i);
            }
          
        }
           
    }
}

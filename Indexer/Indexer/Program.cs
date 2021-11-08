using System;

namespace Indexer
{
    //indexer is like array but not array .
    // In indexer we use instance with array notation 
    //It is a property type
    class indexer
    {

        public string[] array = new string[5];

        public string this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
      
    }
    class Program
    {

        
        static void Main(string[] args)
        {
            indexer in1 = new indexer();
            in1[0] = "ANGELA";
            in1[1] = "OMI";
            in1[2] = "oishi";
            in1[3] = "SARKAR";

            for(int i = 0; i<4;i++)
            {
                Console.WriteLine(in1[i]);
            }
        }
    }
}

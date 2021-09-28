using System;

namespace Constructor1
{
    class Program
    {
        struct Box
        {
            public int height;
            public int width;

            public Box(int H, int W)
            {
                Console.WriteLine("Parameterized constructor");
                height = H;
                width = W;
            }
        

        }
        static void Main(string[] args)
        {
            Box b1 = new Box(200,150); //new instance create
            Console.WriteLine("Box height:"+b1.height);
            Console.WriteLine("Box Width : "+b1.width);
           
        }
    }
}

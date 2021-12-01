using System;

namespace Generic
{
    class GenericMethod
    {
        public void Display<T>(T a,T b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }
    class GenericClass<T>
    {
        public T name;

        public void setName(T name)
        {
            this.name = name;

        }
        public T getName()
        {
            return name;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> gc = new GenericClass<string>();
            gc.setName("I am Angela and I will be rich oneday");
            Console.WriteLine(gc.getName());

            GenericClass<int> gc1 = new GenericClass<int>();
            gc1.setName(20);
            Console.WriteLine(gc1.getName());
            GenericMethod gc2 = new GenericMethod();
            gc2.Display<int>(23,21);
            gc2.Display<Double>(28, 26);
            gc2.Display<string>("We","Married");

        }
    }
}

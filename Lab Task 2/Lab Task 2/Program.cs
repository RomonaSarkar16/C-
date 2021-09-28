using System;

namespace Lab_Task_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("---------------");
            Console.WriteLine("----Access Modifier and Empty Constructors----");
            Romona r = new Romona(); //1st object for empty constructor

            r.name = "Romona Magdalene Sarkar";
            r.id = "20-42186-1";
            r.setCgpa(3.86);
            r.semester=6;
            r.setProgram("CSE");
            r.university = "AIUB";
            r.Display();
            Console.WriteLine("---------------");
            
            //Creating 2nd Object for parameterized constructor
            Console.WriteLine("----Access Modifier and other Constructor----");
            Romona r2 = new Romona("Romona Magdalene","20-42186-1",3.86,6,"CSE","AIUB");
            r2.Display();

            //Creating 3rd Object for Copy Constructor
            Console.WriteLine("____COPY CONSTRUCTOR CALLED____");
            Romona r3 = new Romona(r2);
           

           
            r3.Display();
            


        }
        
    }
}

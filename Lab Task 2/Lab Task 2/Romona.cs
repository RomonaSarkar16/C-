using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Task_2
{
    class Romona
    {
        public string name;
        internal string id;
        private double cgpa;
        public int semester;
        protected string program;
        public string university;

        public void setName(string name)
        {
            this.name = name;
        }
        public void setId(string id)
        {
            this.id = id;
        }
        public void setCgpa(double cgpa)
        {
            this.cgpa = cgpa;
        }
        public void setSemester(int semester)
        {
            this.semester = semester;
        }
        public void setProgram(string program)
        {
            this.program = program;
        }
        public void setUniversity(string university)
        {
            this.university = university;
        }
        public double getCgpa()
        {
            return cgpa;
        }
        //Empty Constructor 
        public Romona()
        {
            Console.WriteLine("______EMPTY CONSTRUCTOR CALLED______");

        }
        //parameterized Constructor 
        public Romona(string name,string id,double cgpa,int semester,string program,string university)
        {
            Console.WriteLine("_______PARAMETERIZED CONSTRUCTOR CALLED_________");
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
            this.semester = semester;
            this.program = program;
            this.university = university;

   
        
        }
        public Romona(double cgpa)
        {
            this.cgpa = cgpa;
        }

        //Copy Constructor using

        public Romona(Romona  R)

        {
            name = R.name;
            id = R.id;
            cgpa = R.cgpa;
            semester = R.semester;
            program = R.program;
            university = R.university;
        }

        //static constructor 
        static Romona()
        {
            Console.WriteLine("____STATIC CONSTRUCTOR CALLED____");
        }

        /*private Romona()
        {
            Console.WriteLine("Private Constructor");
        }*/



        public void Display()
        {
            Console.WriteLine("Name      : " + name);
            Console.WriteLine("ID        : "+ id);
            Console.WriteLine("Cgpa      : " + cgpa);
            Console.WriteLine("Semester  : " + semester);
            Console.WriteLine("Program   : "+ program);
            Console.WriteLine("University: "+ university);
        }

    }
}

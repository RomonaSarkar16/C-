using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_1
{
    class Admin : Person //inheritance
    {

        public Admin()
        {
            Console.WriteLine("Empty Parameter Admin");
        }
        //calling base class constructor
        public Admin(string name, string Dob,int aid,Salary sal) : base(name,Dob)
        {
            Console.WriteLine("Parameterized Parameter of Admin");
            this.aid = aid;
            this.sal = sal;
        }

        private int aid;
        private Salary sal;


       

        public void setAid(int aid)
        {
            this.aid = aid;
        }
       
        public int getAid()
        {
            return aid;
        }
        public void setSal(Salary sal)
        {
            this.sal = sal;
        }

        public void getSal()
        {
            sal.Display();
        }
    }
}

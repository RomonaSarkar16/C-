using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_1
{
    class Person
    {

        public Person()
        {
            Console.WriteLine("Empty Parameter");
        }

        public Person(string name,string Dob)
        {
            Console.WriteLine("Parameterized Parameter");
            this.name = name;
            this.Dob = Dob;
        }

        private string name;
        private string Dob;

        public void setName(string name)
        {
            this.name = name;
        }
        public void setDob(string Dob)
        {
            this.Dob = Dob;
        }
        public string getName()
        {
            return name;
        }

        public string getDob()
        {
            return Dob;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_1
{
    class Employee: Person 
    {
        private int eid;
        private Salary sal;




        public void setEid(int eid)
        {
            this.eid = eid;
        }
        public int getEid()
        {
            return eid;
        }
        public void setSal(Salary sal)
        {
            this.sal = sal;
        }

        public Salary getSal()
        {
            return sal;
        }
    }
}

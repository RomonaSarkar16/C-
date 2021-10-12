using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_1
{
    class Customer : Person
    {
        private int cusId;


        public void setcusId(int cusId)
        {
            this.cusId = cusId;
        }
        public int getcusId()
        {
            return cusId;
        }

    }
}

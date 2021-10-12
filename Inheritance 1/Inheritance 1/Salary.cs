using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_1
{
    class Salary
    {
        private string category;
        private double salAmount;

        public void setCategory(string category)
        {
            this.category = category;
        }
        public string getCategory()
        {
            return category;
        }
        public void setSalamount(double salAmount)
        {
            this.salAmount= salAmount;
        }
        public double getSalamount()
        {
            return salAmount;
        }
        public void Display()
        {
            Console.WriteLine("Category : " + getCategory());
            Console.WriteLine("Salary : " + getSalamount());
        }
    }
}

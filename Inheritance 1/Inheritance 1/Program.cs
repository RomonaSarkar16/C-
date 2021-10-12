using System;

namespace Inheritance_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Salary s1 = new Salary();
            s1.setCategory("AA");
            s1.setSalamount(60000);

            Salary s2 = new Salary();
            s2.setCategory("AB");
            s2.setSalamount(55000);


            Admin A1 = new Admin();
            A1.setName("Romona");
            A1.setDob("28-Feb-2000");
            A1.setAid(1);
            A1.setSal(s1);

            Console.WriteLine("Name : "+ A1.getName());
            Console.WriteLine("Date of Birth : " + A1.getDob());
            Console.WriteLine("Admin Id : " + A1.getAid());
            A1.getSal();
            

            Admin A2 = new Admin("Aurth","12-feb-2000",12,s2);

            Console.WriteLine("Name : " + A2.getName());
            Console.WriteLine("Date of Birth : " + A2.getDob());
            Console.WriteLine("Admin Id : " + A2.getAid());
            A2.getSal();



            Employee e1 = new Employee();
             e1.setName("Ema");
             e1.setDob("20-Sept-2001");
             e1.setEid(100);

             Console.WriteLine("Name : " + e1.getName());
             Console.WriteLine("Date of Birth : " + e1.getDob());
             Console.WriteLine("Admin Id : " + e1.getEid());

             Customer c1 = new Customer();
             c1.setName("nina");
             c1.setDob("12-Jan-2000");
             c1.setcusId(190);

             Console.WriteLine("Name : " + c1.getName());
             Console.WriteLine("Date of Birth : " + c1.getDob());
             Console.WriteLine("Admin Id : " + c1.getcusId());


           

        }
    }
}

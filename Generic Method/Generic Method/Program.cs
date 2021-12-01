using System;
using System.Collections.Generic;

namespace Generic_Method
{

    class Students
        //user difined list
    {
        public int Id { set; //property
            get;
        }
        public string Name { set; get; }
        public double CGPA
        {
            set; get;
         }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.Add(5);
            Students s1 = new Students();
            s1.Id = 123;
            s1.Name = "Angela";
            s1.CGPA = 3.79;

            //user difined list
            List<Students> slist = new List<Students>()
            {
                new Students { Id = 2, Name = "Rayied", CGPA = 3.73 }, //0
                new Students { Id = 3, Name = "Amin", CGPA = 3.43 },//2
                new Students { Id = 4, Name = "Omi", CGPA = 3.53 } //3
            };
            slist.Insert(1, s1); //1
            slist.Remove(s1); //s1 object remove by REMOVE COMMENT
          slist.RemoveAt(0); // InDex remove by REMOVE AT COMMENT


            foreach (Students i in slist)
            {
                Console.WriteLine(i.Id + " " + i.Name + " " + i.CGPA);
            }



        }
    }
}

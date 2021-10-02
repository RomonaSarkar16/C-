using System;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello c# /");
            string Hero = "Erika";
            Console.WriteLine(Hero);
            Console.WriteLine("micheal + " + Hero);
            Console.WriteLine("The length of the Hero string is : " + Hero.Length);
            Console.WriteLine("Capital : " + Hero.ToUpper());
            Console.WriteLine("Small   : " + Hero.ToLower());

            //Concatenation
            string A = "Damon ";
            string D = "Micheal ";
            // string name = Hero + Hero.ToLower();
            string B = A + Hero;
            Console.WriteLine(B);

            //Concat Mathod
            string Couples = string.Concat(D, Hero);
            Console.WriteLine(Couples);

            // access the characters in a string by referring to its index number inside square brackets
            Console.WriteLine(Hero[2]);
            Console.WriteLine("Index number of A : " + Hero.IndexOf('a'));

            //Escape sequence character
            string Travel = "we are traveling to \"Maldives\". ";
            Console.WriteLine(Travel);

            int x = 100;
            int y = 223;
            int z = x + y;
            Console.WriteLine("Total of numbers : " + z);

            string X = "200 ";
            string Y = "500";
            string Z = X + Y;
            Console.WriteLine(Z);

            string NAME = "Angela";
            string Lname = " Sarkar";
            Console.WriteLine();
            string Name = string.Concat(NAME, Lname);
            Console.WriteLine("Full Name : " + Name);
            Console.WriteLine(Name.GetHashCode());
            Console.WriteLine(Name.ToUpperInvariant());
            Console.WriteLine(Name.ToLowerInvariant());
            Console.WriteLine(Name.GetType());
            Console.WriteLine(Name.GetTypeCode());
            Console.WriteLine(Name.Insert(0, "Darling "));
            Console.WriteLine("Normalized : " + NAME.IsNormalized());
            Console.WriteLine("Last index of :" + Lname.LastIndexOf("r"));
            Console.WriteLine("Remove a character :" + Name.Remove(5));
            Console.WriteLine("replace characters : " + Name.Replace("g", "j"));
            Console.WriteLine(NAME.ToCharArray()); //tochararray() method->Converts string into char array.
            Console.WriteLine("Does NAME starts with n :" + NAME.StartsWith("n"));//Check wheter first character of string is same as specified value

            String angela = " angela sarkar   ";
            Console.WriteLine(angela.Trim());//trim() method->	It removes extra whitespaces from beginning and ending of string.
            Console.WriteLine("Lets compare : " + NAME.CompareTo(angela));//Compare two string value and returns 0 for true and 1 for false
            Console.WriteLine("Does NAME Ends with A :" + NAME.EndsWith("a"));
            //String interpolation
            Console.WriteLine(" ---String interpolation");
            string author = "Colleen Hoover";
            string book = "Too Late";
            float price = 13.3f;
            string hello = $"{book} is written by the Best Seller Author {author}\n" + $"The book price is {price} .";
            Console.WriteLine(hello);

            //clone() method->make clone of strings
            Console.WriteLine("The clone of Name : " + Name.Clone());

            string b = "ManitobaCanada";
            string a = "TorontoCanada";
            Console.WriteLine("Equal or Not : " + b.Equals(a));


            //Contains method-> returns true/false
            string str = "Welcome To Canada";

            Console.WriteLine("String contains Canada : " + str.Contains("Canada"));
            Console.WriteLine("String contains 1 = " + str.Contains("1"));

            Console.WriteLine("First character of the string is = " + str[0]);
            Console.WriteLine("Second character of the string is = " + str[1]);
            Console.WriteLine("9th character of the string is = " + str[11]);


            //indexof method->find the index position of a specific character in a string
            Console.WriteLine(str.IndexOf("Welcome"));
            Console.WriteLine(str.IndexOf("To"));
            Console.WriteLine(str.IndexOf("Canada"));
            Console.WriteLine(str.IndexOf("m"));


            //substring method->
            //which extracts the characters from a string,
            //starting from the specified character position/index,
            //and returns a new string.
            //This method is often used together with IndexOf() to get the specific character position
            Console.WriteLine("Index 6 Character = " + str.Substring(7));//outputs index 6 character
            Console.WriteLine("Position 6 to 11 chararacter = " + str.Substring(0, 2));//returns 6 to 11 position strings
            int pos = str.IndexOf("c");
            string last = str.Substring(pos);
            Console.WriteLine(last);

            //Split String Into an Array

            string province = "Ontario,Monitoba,Toronto,Sckachuwan,Calgary";
            string[] provincesList = province.Split(",");
            foreach (string pro in provincesList)
                Console.WriteLine("Provinces : "+pro);
        }
    }
}

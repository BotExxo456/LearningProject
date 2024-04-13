namespace OldStyleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 31;
            string name = "Alfonso";
            string status = "Boomer";

            //String concatenation
            Console.WriteLine("String concatenation");
            Console.WriteLine("Hello my name is " + name +" , I am " + age + " years old");


            // String formatting
            // done through Index

            Console.WriteLine("String Formatting"); 
            Console.WriteLine("Hello my name is {0}, I am {1} years old, and I identify as a {2}", name, age, status);

            // String interpolation
            // Done with $

            Console.WriteLine("String interpolation");
            Console.WriteLine($"Hello my name is {name} , I am {age} years old, and I identify as a {status}");

            //Verbatim strings.

            //Done with @ and takes anything literally, even spaces and empty rows

            Console.WriteLine("Verbatim Strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet,

and I think chicken nuggets are yum");
            string firstName = "Lucas";
            string lastName = "Reinisch";
            string fullName = string.Concat("", firstName, lastName,"");

            Console.WriteLine(fullName.Trim());
            Console.WriteLine(fullName.IndexOf("L"));
            // Escape Characters


            string s1 = "this is a \"string\" with a \nbackslash \\ and a colon: ";
            Console.WriteLine(s1);

            // var keyword

            var number = 0;
            var text = "Text";
            var isTrue = false;


        }
    }
}

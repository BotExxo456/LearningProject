using System;
using System.Reflection.Metadata.Ecma335;

namespace String_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
         
            Console.WriteLine("Please enter your name and press enter");
            name = Console.ReadLine();
            string nameFix = String.Format(name);
            Console.WriteLine($"{nameFix.ToUpper()}\n{nameFix.ToLower()}\n{nameFix.Trim()}\n{nameFix.Substring(0, 1)}");
            


            //Couldnt figure out the substring (Edit: Fixed it, didnt know substring, needed specified Index's)
            //Had to do the string nameFix = String.Format(name) because it would otherwise just break with numbers (didnt have this before)

            //Teacher solution =

            string myName;
            Console.WriteLine("Please enter your name and press enter");
            myName = Console.ReadLine();
            string myNameUpperCase = String.Format("Upper case : {0},", myName.ToUpper());
            string myNameLowerCase = String.Format("Lower Case : {0},", myName.ToLower());
            string myNameTrimmed = String.Format("Trimmed : {0},", myName.Trim());
            string myNameSubString = String.Format("Substring : {0},", myName.Substring(0, 5));

            Console.WriteLine(myNameUpperCase);
            Console.WriteLine(myNameLowerCase);
            Console.WriteLine(myNameTrimmed);
            Console.WriteLine(myNameSubString);

        }
    }
}

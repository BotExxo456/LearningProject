﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        string? answer = Console.ReadLine();
        bool isNumber;
        
        isNumber = Int32.TryParse(answer, out int intAnswer);
        NestedCheck(intAnswer);
    }
    public static void NestedCheck( int number )
    {
        if(number % 3 == 0)
        {
            Console.WriteLine("Divisible by 3.");
        }
        else if(number % 7 == 0)
        {
            Console.WriteLine("Divisible by 7.");
        }
        else if(number % 2 != 0)
        {
            Console.WriteLine("Odd number.");
        }
        else
        {
            Console.WriteLine("Even number.");
        }
        Console.Read();
    }
    
}
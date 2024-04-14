using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static void Main(string[] args)
    {
        //LogIn();
        Register();
        LogIn2();
    }

    //My Solution:
    public static void LogIn()
    {
        Console.WriteLine("Hello, for the registration process we need a username, please enter this one now:");
        string? userName = Console.ReadLine();
        Console.WriteLine("Good, and now enter a password:");
        string? password = Console.ReadLine();
        Console.WriteLine("Now lets log in");
        string? isUserCorrect =Console.ReadLine();
        string? isPasswordCorrect = Console.ReadLine();
        if(isUserCorrect == userName && isPasswordCorrect == password)
        {
            Console.WriteLine("Login successfull!");
        }
        else if(isUserCorrect == userName && isPasswordCorrect != password)
        {
            Console.WriteLine("Password incorrect");
        }
        else if(isUserCorrect != userName && isPasswordCorrect == password)
        {
            Console.WriteLine("Username is wrong");
        }
        else 
        {
            Console.WriteLine("Neither password nor username was correct");
        }
        
    }
    //Teacher solution:  
    static string? username2;
    static string? password2;
    public static void Register()
    {
        Console.WriteLine("Please enter your username");
        username2 = Console.ReadLine();
        Console.WriteLine("Please enter your password");
        password2 = Console.ReadLine();
        Console.WriteLine("Registration completed");
    }
    public static void LogIn2()
    {
        Console.WriteLine("Please enter your username");
        if(username2 == Console.ReadLine())
        {
            Console.WriteLine("Please enter your password");
            if(password2 == Console.ReadLine())
            {
               Console.WriteLine("Login Successfull");
            }
            else
            {
                Console.WriteLine("Login failed, wrong password, please restart program");
            }
        }
        else
        {
            Console.WriteLine("Login failed, wrong Username, please restart program");
        }
        Console.Read();
    }
}
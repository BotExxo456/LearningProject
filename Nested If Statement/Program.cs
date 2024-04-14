internal class Program
{
    private static void Main(string[] args)
    {

        bool isAdmin = false;
        bool isRegistered = true;
        string userName = "";
        Console.WriteLine("Please enter your username");
        userName = Console.ReadLine();
        // try this
        if (isRegistered && userName !="" && userName.Equals("admin"))
        {
            Console.WriteLine("Hi there, registered user!");
           
            Console.WriteLine($"Hi there, {userName}!"); 
              
            Console.WriteLine("Hi there, Admin");
        }
        //Also works, just gets confusing and should be avoided if possible
        if(isRegistered)
        {
            Console.WriteLine("Hi there, registered user!");
            if(userName != "")
            {
               Console.WriteLine($"Hi there, {userName}!"); 
               if(userName.Equals("admin"))
               {
                    Console.WriteLine("Hi there, Admin");
               }
            }
        }
        if(isAdmin || isRegistered)
        {
            Console.WriteLine("You are logged in");
        }



        Console.Read();
    }
    
}
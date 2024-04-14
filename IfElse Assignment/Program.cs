internal class Program
{
    static void Main(string[] args)
    {
        //my solution:
        Console.WriteLine("Please enter your number");
        string? answer = Console.ReadLine();
        int answerAsInt;
        bool isNumber = int.TryParse(answer, out answerAsInt);
        Check(answerAsInt);
        Console.Read();
    }
//my solution(Teacher actually just wanted the method, not to print it out, so plus points for me I guess):
    public static void Check(int number)
    {
        if (number == 0)
        {
            Console.WriteLine("You entered a non viable character, so we'll default it to 0");
        }
        else if(number % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        
        else
        {
            Console.WriteLine("Odd");
        }
    }
        
    
}
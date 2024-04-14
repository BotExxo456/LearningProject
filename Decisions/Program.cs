internal class Program
{
    private static void Main(string[] args)
    {
        // if(condition){
        //      what to do if condition is met
        //}else{
        //      what to do if none of the conditions is met
        //}

        Console.WriteLine("How warm is it today?");
        string? answer = Console.ReadLine();
        int intAnswer; 
        int number;
        if(Int32.TryParse(answer, out number))
        {
            intAnswer = number;
        }
        else
        {
            intAnswer = 0;
            Console.WriteLine("Value entered, was no number. 0 set as temperature");
        }
        if(intAnswer < 15)
        {
            Console.WriteLine("Take the Coat");
        }else if(intAnswer == 15)
        {
            Console.WriteLine("It's a bit chilly today");
        }
        else
        {
            Console.WriteLine("It's cozy outside, maybe bring a hoodie");    
        }
        Console.Read();
    }
}
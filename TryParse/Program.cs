internal class Program
{
    private static void Main(string[] args)
    {
        string numberAsString = "128";
        int parsedValue;

        bool success = Int32.TryParse(numberAsString, out parsedValue);

        if(success)
            {
            Console.WriteLine($"Parsing successful number is {parsedValue}");
            }
        else
            {
                Console.WriteLine("Parsing failed");
            }
        
        
    }
}
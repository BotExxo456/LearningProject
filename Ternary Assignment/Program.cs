internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please enter the temperature");
        string? answer = Console.ReadLine();
        int answerAsInt;
        bool isInt = Int32.TryParse(answer, out answerAsInt);
        answer = isInt == false ? "Not a valid Temperature" : answerAsInt < 15 ? "it is too cold here" : answerAsInt > 16 && answerAsInt < 28 
        ? "it is ok" : "it is hot here";
        Console.WriteLine(answer);
        Console.Read();
    }
}
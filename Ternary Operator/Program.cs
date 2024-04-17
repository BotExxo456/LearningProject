internal class Program
{
    private static void Main(string[] args)
    {
        // condition ? first_expression : second_expression;
        // condition has to be either true or false
        // The conditional operator is right - assovicative
        //The expression a? b: c? d:e
        //is evaluated as a ? b : (c ? d : e).
        // not as (a? b : c) ? d: e.
        // The conditional operator cannot be overloaded.
        
        int temperature = 1000;
        string stateOfMatter;
        /*
        if(temperature < 0)
            stateOfMatter = "solid";
        else
            stateOfMatter = "liquid";
        */
        
        

        // in short:
        stateOfMatter = temperature < 0 ? "solid" : temperature > 100 ? "gas" : "liquid";
        
        Console.WriteLine($"State of matter is {stateOfMatter}");
        Console.Read();
    }
}
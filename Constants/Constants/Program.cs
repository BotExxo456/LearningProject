namespace Constants
{
    internal class Program
    {
        // Constants are immutable values (non changeable) which are known
        // constants as fields ,in the class, outside of method
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;

        // Create a constant of type string with your birthday as its value

        const string birthDate = "07.03.2000";

        static void Main(string[] args)
        {
            Console.WriteLine(birthDate);
            Console.WriteLine("Do whatever you want"); 

            int burgerKing = 4;

            Console.WriteLine(burgerKing);
        }
    }
}

namespace String_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string enteredString;
            char answeredString;
            string firstName;
            string lastName;

            Console.WriteLine("Enter a string here:");
            enteredString = Console.ReadLine();
            Console.WriteLine("Enter the character to search: ");
            answeredString = Console.ReadLine()[0];

            Console.WriteLine("Index of searched character: " + enteredString.IndexOf(answeredString));
            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine($"{firstName} {lastName}");

            string fullname = string.Concat(firstName, " ", lastName);
            Console.WriteLine($"Your full name is  {fullname} ");
        }
    }
}

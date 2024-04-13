namespace User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number you'd like to use for an additon:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Please enter the 2nd number you'd like to use for an additon:");
            string input2 = Console.ReadLine();
            Console.WriteLine(ResultAddition(Int32.Parse(input1), Int32.Parse(input2)));

            Console.Read();
        }

        public static int ResultAddition(int answer1, int answer2)
        {
            return answer1 + answer2;
        }
    }
}

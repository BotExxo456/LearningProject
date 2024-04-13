namespace Method_Assignment_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string s = "HeY ThErE !";
            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);
            Console.ReadKey();
        }
        public static string LowUpper(string answer)
        {
            string answer1 = answer.ToLower();
            string answer2 = answer.ToUpper();

            return answer1 + answer2;

        }
        public static void Count(string answer)
        {
            int answer3 = answer.Length;
            Console.WriteLine($"The amount of characters is {answer3}.");
        }


        // Teacher sol:

        public class Method
        {
            public static string LowUpper(string s)
            {
                return s.ToLower() + s.ToUpper();
            }

            public static void Count(string s)
            {
                Console.WriteLine($"The amount of characters is {s.Length}.");
            }

            public static void Run()
            {
                string s = "HeY ThErE !";

                s = LowUpper(s);
                Console.WriteLine(s);
                Count(s);
            }

        }
    }
}

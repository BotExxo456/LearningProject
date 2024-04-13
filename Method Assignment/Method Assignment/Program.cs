using System.Threading.Channels;

namespace Method_Assignment
{
    internal class Program
    {
        
        

        static void Main(string[] args)
        {
            string friend1 = "Erd";
            string friend2 = "Lyra";
            string friend3 = "Tsuni";

            GreetFriend($"{friend1}, {friend2}, {friend3}");
            Console.Read();
        }

        public static void GreetFriend(string friend)
        {
            Console.WriteLine("Hi " + friend + ",my friends");
        }
    }
}

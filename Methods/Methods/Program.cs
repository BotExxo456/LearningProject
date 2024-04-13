namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Lucas", age = "24";
            string friend2 = "Bob", age2 = "28";
            string friend3 = "Jerome", age3 = "29";

            Console.WriteLine(Add(15, 31));
            Console.WriteLine(Multiply(3, 7));
            Console.WriteLine(Division(9, 4));

            Age(friend1, age);
            Age(friend2, age2);
            Age(friend3, age3);
            Console.Read();
        }


        public static int Multiply(int m1, int m2)
        {
            return m1 * m2;
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }


        public static double Division(double num1, double num2)
        {
            return num1 / num2;
        }

        public static void Age(string friend, string age)
        {
            Console.WriteLine("Oh wow, " + friend + " You're already " + age + " years old");
            
        }
    }
}

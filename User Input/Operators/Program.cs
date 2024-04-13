namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators
            num3 = -num1;
            Console.WriteLine($"num 3 is {num3}");

            bool isSunny = true;
            Console.WriteLine($"is it sunny? {!isSunny}");

            //increment operators

            int num = 0;
            num++;

            Console.WriteLine($"num is {num}");
            // post increment
            Console.WriteLine($"num is {num++}");

            // pre increment
            Console.WriteLine($"num is {++num}");

            //decrement operator
            Console.WriteLine($"num is {num}");
            // post decrement
            Console.WriteLine($"num is {num--}");

            // pre decrement
            Console.WriteLine($"num is {--num}");

            //

            int result;

            result = num1 + num2;
            Console.WriteLine($"result of num1 + num2 is {result}");
            result = num1 - num2;
            Console.WriteLine($"result of num1 - num2 is {result}");
            result = num1 / num2;
            Console.WriteLine($"result of num1 / num2 is {result}");
            result = num1 * num2;
            Console.WriteLine($"result of num1 * num2 is {result}");
            result = num1 & num2;
            Console.WriteLine($"result of num1 & num2 is {result} (Restwert einer Division)");


            // relational and type operators
            
            bool isLower;
            isLower = num1 > num2;

            Console.WriteLine($"result of num1 > num2 is {isLower}");

            // equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine($"result of num1 == num2 is {isEqual}");

            isEqual = num1 != num2;
            Console.WriteLine($"result of num1 != num2 is {isEqual}");

            // conditional operators

            bool isLowerAndSunny;
            // condition1 and condition2 is true
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine($"result of isLower && isSunny is {isLowerAndSunny}");
            // OR operator condition1 or condition2 is true
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine($"result of isLower || isSunny is {isLowerAndSunny}");
            Console.ReadKey();
        }
    }
}

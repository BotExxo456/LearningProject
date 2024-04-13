namespace Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();
            
            try
            {
                int userInputAsInt = Int32.Parse(userInput);
                Console.WriteLine("Lets divide the number by 0 then");
                Console.WriteLine(Int32.Parse(userInput) / 0);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Sorry it's a joke, we can't divide by 0 but we'll give you 1 as an answer");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time.");

                // usually would only be catch(Exception) but because we used throw; to see the Exception we know it's a format Exception
            }

            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too short for an Int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty(null)");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }

            Console.ReadKey();
        }
    }
}

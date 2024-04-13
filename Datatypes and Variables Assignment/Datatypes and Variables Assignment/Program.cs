namespace Datatypes_and_Variables_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte byteTest = 255;
            sbyte sbyteTest = 127;
            int intTest = 20000000;
            uint uintTest = 200000000;
            short shortTest = 32000;
            ushort ushortTest = 65000;
            long longTest = 200000000000000000;
            float floatTest = 30.25f;
            double doubleTest = 30.25345353;
            char charTest = 'a';
            bool boolTest = true;
            string stringTest = "test";
            decimal decimalTest = 30.2534535378m;
            string textController = "I control text";
            string numberParse = "10";
            int convertedParse = Int32.Parse(numberParse);

            Console.WriteLine($"{byteTest}\n{sbyteTest}\n{intTest}\n{uintTest}\n{shortTest}\n{ushortTest}\n{longTest}\n" +
                $"{floatTest}\n{doubleTest}\n{charTest}\n{boolTest}\n{stringTest}\n{textController}\n{convertedParse}");
        }
    }
}

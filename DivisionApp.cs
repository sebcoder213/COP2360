
namespace DivisionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();

            DivideStrings(input1, input2);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void DivideStrings(string str1, string str2)
        {
            try
            {
                int num1 = int.Parse(str1);
                int num2 = int.Parse(str2);
                int result = num1 / num2;

                Console.WriteLine($"Result: {num1} / {num2} = {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: One or both inputs are not valid integers.");
                Console.WriteLine($"Debug info: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                Console.WriteLine($"Debug info: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error: One or both numbers are too large or too small to fit in an Int32.");
                Console.WriteLine($"Debug info: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
            }
        }
    }
}

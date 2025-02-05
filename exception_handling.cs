using System;

class DivisionExceptionHandling
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter the dividend:");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the divisor:");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int result = dividend / divisor;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numeric values.");
        }
    }
}
using System;

class FactorialRecursion
{
    static void Main()
    {
        Console.WriteLine("Enter a number to calculate its factorial:");
        int number = Convert.ToInt32(Console.ReadLine());

        long factorial = CalculateFactorial(number);
        Console.WriteLine("Factorial of " + number + " is: " + factorial);
    }

    static long CalculateFactorial(int n)
    {
        if (n <= 1)
            return 1;
        else
            return n * CalculateFactorial(n - 1);
    }
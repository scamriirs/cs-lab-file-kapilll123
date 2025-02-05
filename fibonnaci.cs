using System;

class FibonacciSeries
{
    static void Main()
    {
        Console.WriteLine("Enter the number of terms to print in the Fibonacci series:");
        int terms = Convert.ToInt32(Console.ReadLine());

        long firstTerm = 0, secondTerm = 1;

        Console.WriteLine("Fibonacci Series:");
        if (terms >= 1)
        {
            Console.Write(firstTerm + " ");
        }
        if (terms >= 2)
        {
            Console.Write(secondTerm + " ");
        }

        for (int i = 3; i <= terms; i++)
        {
            long nextTerm = firstTerm + secondTerm;
            Console.Write(nextTerm + " ");
            firstTerm = secondTerm;
            secondTerm = nextTerm;
        }
    }
}
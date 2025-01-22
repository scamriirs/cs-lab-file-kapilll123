using System;

class SumOfInputNumbers
{
    static void Main()
    {
        int sum = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter number " + (i + 1) + ":");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            sum += inputNumber;
        }

        Console.WriteLine("Sum of 10 input numbers: " + sum);
    }
}

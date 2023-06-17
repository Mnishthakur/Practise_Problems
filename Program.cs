using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int number = 12345;
        int sum = CalculateDigitSum(number);
        Console.WriteLine("Sum of digits: " + sum);
    }

    static int CalculateDigitSum(int number)
    {
        int sum = 0;

        while (number != 0)
        {
            int digit = number % 10; // Get the last digit
            sum += digit; // Add the digit to the sum
            number /= 10; // Remove the last digit
        }

        return sum;
    }
}

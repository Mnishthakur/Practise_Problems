using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = { 5, 3, 9, 1, 7, 2, 6, 4, 8 };

        int max = arr[0];
        int min = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }

            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        Console.WriteLine("Maximum element: " + max);
        Console.WriteLine("Minimum element: " + min);
    }
}

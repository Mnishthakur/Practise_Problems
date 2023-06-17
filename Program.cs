using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int rows = 8;

        for (int i = rows; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

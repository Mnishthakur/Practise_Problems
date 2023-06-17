using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int rows = 7;
        int columns = 8;

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= columns; j++)
            {
                if (i == 1 || i == rows || j == 1 || j == columns)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

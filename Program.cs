using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 2, 3, 5, 6, 4, 7, 8, 1, 9, 1 };
        List<int> uniqueElements = GetUniqueElements(arr);

        Console.WriteLine("Unique Elements:");
        foreach (int element in uniqueElements)
        {
            Console.WriteLine(element);
        }
    }

    static List<int> GetUniqueElements(int[] arr)
    {
        List<int> uniqueElements = new List<int>();
        Dictionary<int, bool> duplicates = new Dictionary<int, bool>();

        foreach (int num in arr)
        {
            if (!duplicates.ContainsKey(num))
            {
                duplicates[num] = true;
                uniqueElements.Add(num);
            }
        }
        return uniqueElements;
    }
}

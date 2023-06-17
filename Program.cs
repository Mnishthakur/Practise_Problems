using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 3, 2, 4, 3, 2, 4, 6, 6, 6, 7, 8, 6, 8, 9, 9, 08, 7, 7, 9, 7, 8, 7, 6 };
        Dictionary<int, int> duplicates = CountDuplicates(arr);

        Console.WriteLine("Duplicate Elements:");
        foreach(KeyValuePair<int,int> duplicate in duplicates)
        {
            Console.WriteLine($"{duplicate.Key} - Count : {duplicate.Value}");

        }

        int totalCount = 0;
        foreach (int count in duplicates.Values)
        {
            if(count > 1)
            {
                totalCount += count;
            }
        }
        Console.WriteLine($"Total number of duplicate elements: {totalCount}");
    }

    static Dictionary<int , int> CountDuplicates(int[] arr)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach (int num in arr)
        {
            if (counts.ContainsKey(num))
            {
                counts[num]++;
            }
            else
            {
                counts[num] = 1;
            }
        }
        return counts;
    }
}


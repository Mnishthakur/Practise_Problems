{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 2, 3, 5, 6, 4, 7, 8, 1, 9, 1 };
        Dictionary<int, int> frequency = CountElementFrequency(arr);

        Console.WriteLine("Element Frequency:");
        foreach (KeyValuePair<int, int> pair in frequency)
        {
            Console.WriteLine($"Element: {pair.Key} - Frequency: {pair.Value}");
        }
    }

    static Dictionary<int, int> CountElementFrequency(int[] arr)
    {
        Dictionary<int, int> frequency = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (frequency.ContainsKey(num))
            {
                frequency[num]++;
            }
            else
            {
                frequency[num] = 1;
            }
        }

        return frequency;
    }
}

using system;
class Program
{
    static void Main()
    {
        string input = "Manish";
        string reversed = ReverseWords(input);
        Console.WriteLine(reversed);
    }

    static string ReverseWords(string input)
    {
        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = ReverseString(words[i]);
        }
        return string.Join(" ", words);
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

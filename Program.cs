class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        int[] rowSums = new int[rows];

        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < columns; j++)
            {
                rowSum += matrix[i, j];
            }
            rowSums[i] = rowSum;
        }

        Console.WriteLine("Sum of each row:");
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine("Row {0}: {1}", i + 1, rowSums[i]);
        }
    }
}

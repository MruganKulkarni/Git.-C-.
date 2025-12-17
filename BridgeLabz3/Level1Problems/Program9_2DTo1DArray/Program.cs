using System;

class Program
{
    static void Main()
    {
        Console.Write("Rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];
        int[] array = new int[rows * cols];
        int idx = 0;

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
                array[idx++] = matrix[i, j];
            }

        Console.WriteLine("1D Array:");
        foreach (int val in array)
            Console.WriteLine(val);
    }
}

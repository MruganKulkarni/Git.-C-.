using System;

class Program
{
    static void Main()
    {
        double[] heights = new double[11];
        double sum = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write($"Enter height of player {i + 1}: ");
            heights[i] = double.Parse(Console.ReadLine());
            sum += heights[i];
        }

        Console.WriteLine($"Mean height = {sum / heights.Length}");
    }
}

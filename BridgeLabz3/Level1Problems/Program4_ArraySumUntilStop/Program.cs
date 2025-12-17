using System;

class Program
{
    static void Main()
    {
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        while (true)
        {
            Console.Write("Enter number: ");
            double value = double.Parse(Console.ReadLine());

            if (value <= 0 || index == 10)
                break;

            numbers[index++] = value;
        }

        for (int i = 0; i < index; i++)
            total += numbers[i];

        Console.WriteLine($"Sum of values is {total}");
    }
}

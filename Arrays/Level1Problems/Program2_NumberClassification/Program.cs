using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());

            if (numbers[i] > 0)
                Console.WriteLine(numbers[i] % 2 == 0 ? "Positive even" : "Positive odd");
            else if (numbers[i] < 0)
                Console.WriteLine("Negative");
            else
                Console.WriteLine("zero");
        }

        if (numbers[0] == numbers[4])
            Console.WriteLine("First and last elements are equal");
        else if (numbers[0] > numbers[4])
            Console.WriteLine("First element is greater");
        else
            Console.WriteLine("Last element is greater");
    }
}

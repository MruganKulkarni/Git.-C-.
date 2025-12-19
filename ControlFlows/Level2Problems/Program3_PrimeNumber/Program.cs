using System;

class Program
{
    static void Main() {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = number > 1;
        for (int i = 2; i <= number / 2 && isPrime; i++)
        {
            if (number % i == 0)
                isPrime = false;
        }
        Console.WriteLine(isPrime ? "Prime Number" : "Not a Prime Number");
    }
}

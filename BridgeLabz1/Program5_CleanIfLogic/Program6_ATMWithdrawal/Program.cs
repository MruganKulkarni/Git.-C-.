using System;

class Program
{
    static void Main()
    {
        int balance = 30000;
        int minimumBalance = 1000;
        int dailyLimit = 20000;

        Console.Write("Enter withdrawal amount: ");
        int amount = int.Parse(Console.ReadLine());

        if (amount <= dailyLimit)
        {
            if (amount <= balance - minimumBalance)
            {
                Console.WriteLine("Withdrawal successful");
            }
            else
            {
                Console.WriteLine("Insufficient balance (minimum balance must be maintained)");
            }
        }
        else
        {
            Console.WriteLine("Amount exceeds daily withdrawal limit");
        }
    }
}

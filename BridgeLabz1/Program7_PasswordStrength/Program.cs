
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        int score = 0;

        if (password.Length >= 8)
            score++;

        bool hasDigit = false;
        bool hasSpecial = false;

        foreach (char c in password)
        {
            if (char.IsDigit(c))
                hasDigit = true;
            else if (!char.IsLetterOrDigit(c))
                hasSpecial = true;
        }

        if (hasDigit)
            score++;
        if (hasSpecial)
            score++;

        if (score == 1)
            Console.WriteLine("Weak");
        else if (score == 2)
            Console.WriteLine("Medium");
        else if (score == 3)
            Console.WriteLine("Strong");
        else
            Console.WriteLine("Very Weak");
    }
}

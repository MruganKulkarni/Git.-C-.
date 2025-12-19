using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter marks: ");
        int marks = int.Parse(Console.ReadLine());

        if (marks >= 0 && marks <= 100 && marks >= 40)
        {
            Console.WriteLine("Pass");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}

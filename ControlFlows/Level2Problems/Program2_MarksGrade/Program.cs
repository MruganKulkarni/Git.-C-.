using System;

class Program
{
    static void Main()
    {
        Console.Write("Physics: ");
        int physics = int.Parse(Console.ReadLine());
        Console.Write("Chemistry: ");
        int chemistry = int.Parse(Console.ReadLine());
        Console.Write("Maths: ");
        int maths = int.Parse(Console.ReadLine());
        double avg = (physics + chemistry + maths) / 3.0;
        string grade;
        if (avg >= 90) grade = "A";
        else if (avg >= 75) grade = "B";
        else if (avg >= 60) grade = "C";
        else grade = "Fail";
        Console.WriteLine($"Average: {avg}, Grade: {grade}");
    }
}

using System;
class marks
{
    static void Main()
    {
        int Physics = 95;
        int math = 94;
        int chemistry = 96;
        int highest = 100;

        int averagepercentage = ((Physics + math + chemistry) * 100) / (3 * highest);
        Console.WriteLine("Average percentage of PCM is: " + averagepercentage + "%");
    }
}
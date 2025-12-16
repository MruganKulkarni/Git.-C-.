using System;
    class Add
{
    static void RunAdd(string[] args)
    {
        int num1, num2, sum;
        Console.WriteLine("Enter the First Number:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Second Number:");
        num2 = Convert.ToInt32(Console.ReadLine());
        sum = num1 + num2;
        Console.WriteLine("The sum of the two number is:" +sum); 
    }
}

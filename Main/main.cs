// using System;
class MainProgram
{
    public static void Main(String[] ___)
    {
        // Console.Write("Enter a number: ");
        // string data = Console.ReadLine();
        // Console.WriteLine(data);

        Console.Write("Enter your age: ");
        int data = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Do you want to continue? (y/n): ");
        char yn = Console.ReadKey().KeyChar;
        Console.WriteLine();
        Console.WriteLine("You selected " + yn);
        // int data = int.Parse(Console.ReadLine());
        Console.WriteLine("Your age is " + data);
        Console.WriteLine(data + 42);


    }
}

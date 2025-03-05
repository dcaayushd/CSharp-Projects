// using System;
class MainProgram
{
    public static void Main(String[] ___)
    {
        Console.WriteLine("\"Hello world!\"");
        Console.WriteLine("\\");
        Console.WriteLine("C:\\Desktop\\Program\\dotnet.exe");
        Console.WriteLine(@"C:\Desktop\Program\dotnet.exe");
        int age = 23;
        string str = $" Your age is {age} years.";
        Console.WriteLine(str);
        Console.WriteLine($"{str} You're an adult now.");
    }
}

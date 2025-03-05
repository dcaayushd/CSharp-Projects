// using System;
class MainProgram
{
    public static void Main(String[] ___)
    {
        string str = "123";
        decimal d = 1234.56789m;
        decimal d1 = 0m;
        int num = Convert.ToInt32(str);
        int num1 = Convert.ToInt32(d);
        bool b = Convert.ToBoolean(d);
        bool b1 = Convert.ToBoolean(d1);
        Console.WriteLine(str);
        Console.WriteLine(num);
        Console.WriteLine(num1);
        Console.WriteLine(b);
        Console.WriteLine(b1);
    }
}

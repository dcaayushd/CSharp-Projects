// using System.Text;
class MainProgram
{
    public static void Main(String[] ___)
    {
        Console.WriteLine(Math.PI);
        Console.WriteLine(Math.E);

        double pi = 3.14;
        double num = 3.98384;
        double num1 = 3.00384; 

        Console.WriteLine(Math.Round(pi));
        Console.WriteLine(Math.Floor(num));
        Console.WriteLine(Math.Ceiling(num1));

        //Examples of Clamp
        Console.WriteLine(Math.Clamp(8, 0, 10));
        Console.WriteLine(Math.Clamp(11, 0, 10));
        Console.WriteLine(Math.Clamp(-1, 0, 10));
        Console.WriteLine(Math.Clamp(4, 5, 10));

        Console.WriteLine(Math.Abs(2));
        Console.WriteLine(Math.Abs(-2));

        Console.WriteLine(Math.Max(12.4, 12.5));
        Console.WriteLine(Math.Min(12.4, 12.5));

        Console.WriteLine(Math.Pow(2,5));
        Console.WriteLine(Math.Sqrt(25));

    }
}

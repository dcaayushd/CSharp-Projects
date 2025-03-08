using static System.Linq.Enumerable;
class MainProgram
{
    unsafe static void Main(string[] ___)
    {

        Foo(out int number);
        Console.WriteLine($"Main: {number}");
    }


    unsafe static void Foo(out int n)
    {
        n = 4;
        Console.WriteLine($"Foo: {n}");

    }

}

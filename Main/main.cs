using static System.Linq.Enumerable;
class MainProgram
{
    unsafe static void Main(string[] ___)
    {
        int number = 42;
        int* ptr = &number;
        Console.WriteLine($"Main: {(ulong)ptr}");
        Foo(number);
    }

    //This gives different address
    // unsafe static void Foo(int n)
    // {
    //     int* ptr = &n;
    //     Console.WriteLine($"Foo: {(ulong)ptr}");

    // }
    unsafe static void Foo(in int n)
    {
        // int other = n + 12;
        int other = n;
        fixed (int* ptr = &n)
            Console.WriteLine($"Foo: {(ulong)ptr}");

    }

}

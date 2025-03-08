using static System.Linq.Enumerable;
class MainProgram
{
    public static void Main(string[] ___)
    {
        // int number = 42;
        // ref int rnum = ref number;
        // rnum = 12;
        // Console.WriteLine(number);

        // int number = 12;
        // ref int n = ref number;
        // n = 42;


        // Console.WriteLine(number);

        int number = 12;

        Foo(ref number);
        Console.WriteLine(number);
    }

    static void Foo(ref int n){
        n = 42;
    }

}

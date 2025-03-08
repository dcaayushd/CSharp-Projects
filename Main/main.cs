using static System.Linq.Enumerable;
class MainProgram
{
    public static void Main(string[] ___)
    {
        int add = Sum(11, 22);
        Console.WriteLine($"The sum of given two numbers is: {add}");
        int div = Div(12, 3);
        Console.WriteLine($"The quotient of given two numbers is: {div}");
    }

    // static void Foo(){
    //     if(false){
    //         return ;
    //     }
            //Foo Code
    // }
    static int Sum(int a, int b)
    {
        // int result = a+b;
        // return result;

        return a + b;
    }
    static int Div(int a, int b)
    {
        // int result = a+b;
        // return result;
        if (b == 0) return 0;

        return a / b;
    }
}
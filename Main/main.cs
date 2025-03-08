using static System.Linq.Enumerable;
class MainProgram
{
    static void Main(string[] ___)
    {

        int add = Sum(2, 5);
        Console.WriteLine($"The sum of the given numbers is : {add}");
        
        int add1 = Sum(2, 5, 6);
        Console.WriteLine($"The sum of the given numbers is : {add1}");
        
        float add2 = Sum(2.120f, 5.340f, 6.09f, 7.980f);
        Console.WriteLine($"The sum of the given numbers is : {add2}");
    }


    static int Sum(int n1, int n2)
    {
        return n1 + n2;

    }
    static int Sum(int n1, int n2, int n3)
    {
        return n1 + n2 + n3;

    }

    static float Sum(float n1, float n2, float n3, float n4)
    {
        return n1 + n2 + n3 + n4;

    }

}

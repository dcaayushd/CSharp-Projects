using static System.Linq.Enumerable;
class MainProgram
{
    static void Main(string[] ___)
    {

        // int add = Sum(2, 5);
        // Console.WriteLine($"The sum of the given numbers is : {add}");

        // int add1 = Sum(2, 5, 6);
        // Console.WriteLine($"The sum of the given numbers is : {add1}");

        // int add2 = Sum(2, 5, 6, 7);
        // Console.WriteLine($"The sum of the given numbers is : {add2}");



        decimal sum = Sum(2.4m, -5, 1.78, 6.9807f, 7, "string");
        Console.WriteLine($"The sum of the given numbers is : {sum}");

    }


    // static int Sum(params int[] numbers)
    // {
    //     int total = 0;
    //     foreach (var num in numbers)
    //     {
    //         total += num;
    //     }
    //     return total;
    // }
    static decimal Sum(params dynamic[] numbers)
    {
        decimal total = 0m;
        foreach (var num in numbers)
        {
            switch (num)
            {
                case int:
                    // break;
                case long:
                    // break;
                case float:
                    // break;
                case double:
                    // break;
                case decimal:
                    total += (decimal)num;
                    break;

                default:
                    Console.WriteLine($"\n\tNot a number {num}\n");
                    break;

            }
        }
        return total;
    }


}

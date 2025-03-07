using static System.Linq.Enumerable;
class MainProgram
{
    public static void Main(string[] ___)
    {
        // // int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // int[,] numbers = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, };
        // foreach (int a in numbers)
        // {
        //     Console.WriteLine(a);
        // }

        // foreach (int a in new int[] { 1, 2, 3, 4, 5})
        // foreach (int a in Range(0,10))
        foreach (var a in Range(0,10))
        {
            Console.WriteLine(a);
        }
    }
}

using static System.Linq.Enumerable;
class MainProgram
{
    public static void Main(string[] ___)
    {
        // int[,] numbers = { 
        //     { 1, 2, 3, 4, 5 }, 
        //     { 6, 7, 8, 9, 10 }, 
        //     { 11, 12, 13, 14, 15 },
        //  };

        //  Console.WriteLine(numbers[1,4]);

        //  numbers[1,4] = -2;
        //  Console.WriteLine(numbers[1,4]);
        // foreach (var a in numbers)
        // {
        //     Console.WriteLine(a);
        // }

        // int[,,] numbers = { {
        //     { 1, 2, 3, 4, 5 },  
        //     { 6, 7, 8, 9, 10 }, 
        //     { 11, 12, 13, 14, 15 },
        //  },
        //  {
        //     { 101, 102, 103, 104, 105 },  
        //     { 106, 107, 108, 109, 1010 }, 
        //     { 1011, 1012, 1013, 1014, 1015 },
        //  },
        //  };

        //  Console.WriteLine(numbers[1,0,3]);

        //  numbers[1,0,3] = 22;
        //  Console.WriteLine(numbers[1,0,3]);
        // foreach (var a in numbers)
        // {
        //     Console.WriteLine(a);
        // }

        int[,] numbers = new int[9, 7];

        // for (int i = 0; i < 9; i++)
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            // for (int j = 0; j < 7; j++)
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write((numbers[i, j] = i + j) + "\t");
            }
            Console.WriteLine();
        }
    }
}
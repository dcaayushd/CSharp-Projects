// using System.Text;
class MainProgram
{
    public static void Main(string[] ___)
    {
        // int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // Random rand = new();
        // numbers[0] = 11;
        // numbers[5] = numbers[1];
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = rand.Next();
        //     Console.Write(numbers[i] + " ");
        // }
        // Console.WriteLine();

        object[] things  = {
            new(),
            new(),
            new(),
            new(),
        };
        Random rand = new();

        things[0] = rand.Next();
        things[1] = "second";
        things[2] = 1.3456;
        things[3] = 12;
         for (int i = 0; i < things.Length; i++)
        {   ;
            Console.WriteLine(things[i]);
        }
        Console.WriteLine();

        /*
        To declare an array fo any size, we can use the following:
        This will make an array of size 100 fro both types.
        */
        int[] numbers = new int[100];
        object[] thing = new object[100];
    }
}

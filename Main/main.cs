// using System.Text;
class MainProgram
{
    public static void Main(string[] ___)
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} is an even number.");
            }
            if (i % 2 == 0) continue;
            Console.WriteLine($"{i} is an odd number.");

            if(i>5) break;

        }

    }
}

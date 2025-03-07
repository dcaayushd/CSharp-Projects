// using System.Text;
class MainProgram
{
    public static void Main(string[] ___)
    {
        // for(int i = 0; i<10; i++){
        //     Console.WriteLine("The current Number is : " + (i+1));
        // }
        int n = 5; // Size of the pattern

        for (int i = 0; i < n; i++)
        {
            if (i == 0 || i == n - 1)
            {
                // Print full row 0 1 2 3 4
                for (int j = 0; j < n; j++)
                {
                    Console.Write(j + " ");
                }
            }
            else if (i == n / 2)
            {
                // Print the middle row with a single '1' centered
                for (int j = 0; j < (n / 2) * 2; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("1");
            }
            else
            {
                // Print rows with 1 2 3, with indentation
                Console.Write("  ");
                for (int j = 1; j < n - 1; j++)
                {
                    Console.Write(j + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

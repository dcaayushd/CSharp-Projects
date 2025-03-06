// using System.Text;
class MainProgram
{
    public static void Main(String[] ___)
    {
        Random rand = new();
        Console.WriteLine(rand.Next());
        Console.WriteLine(rand.Next(0, 11));
        Console.WriteLine(rand.NextDouble());
        Console.WriteLine(rand.NextSingle());
        Console.WriteLine(rand.NextInt64());

    }
}

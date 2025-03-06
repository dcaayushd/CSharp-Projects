// using System.Text;
class MainProgram
{
    public static void Main(String[] ___)
    {
        bool b = true && true;
        bool b1 = false && true;
        bool b2 = false || true;
        bool b3 = false || false;
        bool b4 = true || true;
        bool b5 = !b3;
        Console.WriteLine(b);
        Console.WriteLine(b1);
        Console.WriteLine(b2);
        Console.WriteLine(b3);
        Console.WriteLine(b4);
        Console.WriteLine(b5);
    }
}

using static System.Linq.Enumerable;
class MainProgram
{
    public static void Main(string[] ___)
    {
        // Hello("Aayush");
        string n = "Aayush";
        Hello(n);
    }

    static void Hello(string name){
        Console.WriteLine($"Hello {name},from the other side");
    }
}